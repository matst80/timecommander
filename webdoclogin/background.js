//console.log('backgroudn start',chrome.runtime);
var runtimeOrExtension = chrome.runtime && chrome.runtime.sendMessage ?
                         'runtime' : 'extension';

                         var lasthost;
var username = 'Timelogger';
var logurl = 'https://hooks.slack.com/services/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';
chrome.storage.sync.get({
    username: 'wd.admin',
    title: '',
    password: ''
  }, function(items) {
            username = items.title;
            if (username && username.indexOf('http')!=-1) {
        		username = 'Logger';
        		logurl = items.title;
        	}
            if (!username)
                username = 'Unknown';
        });

var lastshow = new Date();

function shownow() {
    if (new Date()-lastshow>500000) {
        lastshow = new Date();
        var opt = {
            iconUrl: "https://tctechcrunch2011.files.wordpress.com/2011/05/thumbs.png",
            type: 'progress',
            title: 'Rapportera in tiden',
            message: 'Glöm inte bort att ta betalt :)',
            priority: 1,
            progress: Math.round(lastval||0)
        };
        chrome.notifications.create('notify1', opt, function() {  });
    }
}

function showgr8() {
    if (new Date()-lastshow>5000000) {
        lastshow = new Date();
        var opt = {
            iconUrl: "http://previews.123rf.com/images/andreypopov/andreypopov1406/andreypopov140600264/29176671-Portrait-of-successful-young-businessman-with-money-rain-Stock-Photo.jpg",
            type: 'progress',
            title: 'FAAAN va bra vi är!',
            message: 'Nu tar vi betalt, nu ska vi bara ta över världen :)',
            priority: 1,
            progress: 100
          };
          chrome.notifications.create('notify1', opt, function() {  });
    }
}


var lastval = 0;



setInterval(shownow,60*60*1000);

function fetchTime() {
    var req = new XMLHttpRequest();
                req.open(
                    "POST",
                    "http://budget.wd7dev.se/data.asmx/GetDeb",
                    true);
                req.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
                req.onload = function() {
                    //console.log(req);
                    //try {
                        var d = JSON.parse(req.responseText).d;
                        //console.log(d);
                        var daydt = new Date();
                        var pers = daydt.getDay()==5?5:4;
                        var hr = daydt.getDay()==5?8:7;
                        pers-=0.2;
                        var target = pers*0.88*hr;
                        lastval = ((d/60)/target)*100;
                        chrome.browserAction.setBadgeText({text: Math.round(lastval)+'%'});
                        if (lastval>100)
                            showgr8();
                        else 
                            shownow();
                        
                    //}
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
                var st = dt.getFullYear()+'-'+m+'-'+d+'T00:00:02.000Z';
                var et = dt.getFullYear()+'-'+m+'-'+d+'T23:59:59.000Z';
                req.send('{from:"'+st+'",to:"'+et+'"}');
}

//console.log(runtimeOrExtension);
// Bind event:
chrome[runtimeOrExtension].onMessage.addListener(function(request, sender, sendResponse) {
    //console.log('data',request,sender);

    if (request) {
        fetchTime();

        if (request.iscms) {
            
        	chrome.browserAction.enable(sender.tab.id);
        	if (request.url != lasthost) {
        		lasthost = request.url;
    	    	var xmlhttp = new XMLHttpRequest();
    	        var frmdata = new FormData();
    	        frmdata.append('payload', '{ "username":"'+username+'","text": "'+request.url+': '+request.title+'" }');
    	        xmlhttp.open('POST', logurl,true);
    	        xmlhttp.send(frmdata);
            }
        }
        else
        	chrome.browserAction.disable(sender.tab.id);
    }
    sendResponse({ok:true});

});
