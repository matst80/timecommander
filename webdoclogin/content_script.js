function isCavCms()
{
	var res = document.evaluate('//meta[@name="generator"][contains(@content,"Cavagent") or contains(@content,"WebDoc")]',document,null,0,null);
	var iswebdoc = false;
	var t;
	while(t = res.iterateNext())
		iswebdoc = true;
	return iswebdoc;
}



console.log('here',isCavCms());
if (window==top)
{
	var loggedIn = window.wdGlobal;
	console.log('is top');
	/*var xmlhttp = new XMLHttpRequest();
    var frmdata = new FormData();
    frmdata.append('payload', '{ "username":"Logger","text": "'+window.location.hostname+': Visit" }');
	xmlhttp.open('POST', 'https://hooks.slack.com/services/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');
    xmlhttp.send(frmdata);*/

	chrome.runtime.sendMessage({iscms: isCavCms(),loggedin:loggedIn,url:window.location.hostname, title:document.title}, function(response) {
  		console.log('res',response);
	});
}