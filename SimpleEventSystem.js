function Event(name){
  this.name = name;
  this.callbacks = [];
}
Event.prototype.registerCallback = function(callback){
  this.callbacks.push(callback);
};
 
function SampleObject(){
  this.events = {};
}
 
Object.prototype.registerEvent = function(eventName){
  var event = new Event(eventName);
  this.events[eventName] = event;
};
 
Object.prototype.dispatchEvent = function(eventName, eventArgs){
  this.events[eventName].callbacks.forEach(function(callback){
    callback(eventArgs);
  });
};
 
Object.prototype.addEventListener = function(eventName, callback){
  this.events[eventName].registerCallback(callback);
};

var myObject = new SampleObject();

myObject.registerEvent('somethingHappened');

myObject.addEventListener('somethingHappened', function(){
  console.log('Im doing something nice');
});

myObject.addEventListener('somethingHappened', function(){
  console.log('Doing something else');
});

myObject.dispatchEvent('somethingHappened');
