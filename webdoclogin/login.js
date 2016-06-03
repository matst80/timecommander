/*
chrome.extension.onMessage.addListener(function(message, sender, sendResponse) {
    console.log(message,sender);
    sendResponse({status:1});
});
*/

var lasthost;
/*
var logurl = 'http://budget.wd7dev.se/data.asmx';

function fetchTime() {
    var req = new XMLHttpRequest();
                req.open(
                    "POST",
                    "http://budget.wd7dev.se/data.asmx/GetDeb",
                    false);
                req.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
                req.onload = function() {
                    //console.log(req);
                    try {
                        var d = JSON.parse(req.responseText).d;
                        var daydt = new Date();
                        var pers = daydt.getDay()==5?5:4;
                        var hr = daydt.getDay()==5?8:7;
                        var target = pers*0.88*hr;
                        chrome.browserAction.setBadgeText({text: Math.round(((d/60)/target)*100)+'%'});
                    }
                    catch(err)
                    {
                        faillogin();
                        console.log(err);
                    }
                }

                req.onerror = function() {
                    console.log('error fetching time');
                }
                var dt = new Date();
                var m = dt.getMonth()+1;
                var d = dt.getDate();
                var d2 = dt.getDate();
                if (m<10) {
                    m = '0'+m;
                }
                if (d<10)
                {
                    d = '0'+d;
                    d2 = '0'+(d-1);
                }
                var st = dt.getFullYear()+'-'+m+'-'+d2+'T00:00:02.000Z';
                var et = dt.getFullYear()+'-'+m+'-'+d+'T23:59:59.000Z';
                req.send('{from:"'+st+'",to:"'+et+'"}');
}

setTimeout(fetchTime,15000);
fetchTime();
*/
var opt = { username: '',
            password: '',
            title: 'Not set.' };

chrome.storage.sync.get({
    username: 'wd.admin',
    title: '',
    password: ''
  }, function(items) {
    opt = items;
  });

chrome.windows.getCurrent(function(w) {
      chrome.tabs.getSelected(w.id,function (tab){

        var t = document.getElementById('t');
        var l = document.getElementById('login');
        var btn = document.getElementById('dologin');
        var btn_cpl = document.getElementById('cpl');
        //t.innerHTML = tab.url;
        var err = document.getElementById('errmsg');
        var url = tab.url;//.replace('http://','').replace('https://','');
        var safe =  (url.indexOf('https:')!=-1);
        url = url.replace('http://','').replace('https://','');
        var i = url.indexOf('/');
        var nurl = url.substr(0,i);



        function faillogin(errmsg)
        {
            var msg = errmsg||'Inloggning misslyckades';
            t.innerHTML = 'Loggar in...';
            t.style.display = 'none';
            l.style.display = 'block';
            err.innerHTML = msg;
            err.style.display = 'block';
        }

        function dologin() {

			var xmlhttp = new XMLHttpRequest();
	        var frmdata = new FormData();
	        if (nurl!=lasthost) {
	        	lasthost = nurl;
	        	var user = opt.title;
	        	var logurl = 'https://hooks.slack.com/services/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';
	        	if (user.indexOf('http')!=-1) {
	        		logurl = user;
	        		user = 'Login';
        		}
		        frmdata.append('payload', '{ "username":"'+user+'","text": "'+nurl+': Login - '+opt.username+'" }');
		        xmlhttp.open('POST', logurl);
		        xmlhttp.send(frmdata);
	        }
            if (opt.password && opt.username) {
                err.style.display = 'none';

                var req = new XMLHttpRequest();
                req.open(
                    "POST",
                    (safe?'https://':'http://')+nurl+"/Core,Core.WebServices.Admin.asmx/GetLoginCookie",
                    false);
                req.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
                req.onload = function() {
                    //console.log(req);
                    try {
                        var d = JSON.parse(req.responseText).d;
                        if (d.Name && d.Value) {
                            //message('Inloggad...');
                            t.innerHTML = 'Inloggad!';
                            t.style.display = 'block';
                            l.style.display = 'none';
                            err.style.display = 'none';
                            chrome.cookies.set({url:(safe?'https://':'http://')+nurl,name:d.Name,path:d.Path,value:d.Value,httpOnly:d.HttpOnly},function() {
                                chrome.tabs.reload(tab.id,null,function() {
                                    setTimeout(function(){
                                        window.close();
                                    },400);
                                });
                            });
                            //var w = chrome.app.window.current();
                            //w.close();
                        }
                        else {
                            faillogin();
                        };
                    }
                    catch(err)
                    {
                        faillogin();
                        console.log(err);
                    }
                }

                req.onerror = function() {
                    faillogin();
                }
                req.send('{username:"'+opt.username+'",password:"'+opt.password+'"}');
            }
            else
                faillogin('Användarnamn och lösenord behövs för att kunna logga in');
        }
        btn.addEventListener('click',dologin,0);
        btn_cpl.addEventListener('click',function() {
            var newURL = (safe?'https://':'http://')+nurl+'/admin/PluginLoader.aspx';
            chrome.tabs.create({ url: newURL });
        },0);
        document.getElementById('budget').addEventListener('click',function() {
        	var newURL = 'http://budget.wd7dev.se/#/step-3';
            chrome.tabs.create({ url: newURL });
        },0);
    });
});