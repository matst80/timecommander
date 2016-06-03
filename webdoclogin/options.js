// Saves options to chrome.storage
function save_options() {
  var ttit = document.getElementById('ttit').value;
  var user = document.getElementById('tuser').value;
  var pass = document.getElementById('tpass').value;
  
  chrome.storage.sync.set({
    username: user,
    title: ttit,
    password: pass
  }, function() {
    var status = document.getElementById('status');
    status.textContent = 'Options saved.';
    setTimeout(function() {
      status.textContent = '';
    }, 750);
  });
}

// Restores select box and checkbox state using the preferences
// stored in chrome.storage.
function restore_options() {
  // Use default value color = 'red' and likesColor = true.
  chrome.storage.sync.get({
    username: 'wd.admin',
    title: '',
    password: ''
  }, function(items) {
    document.getElementById('ttit').value = items.title;
    document.getElementById('tuser').value = items.username;
    document.getElementById('tpass').value = items.password;
  });
}
document.addEventListener('DOMContentLoaded', restore_options);
document.getElementById('save').addEventListener('click',
    save_options);