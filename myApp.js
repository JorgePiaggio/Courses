var express = require('express');
var app = express();

/* Serve Static Assets

Mount the express.static() middleware for all requests with app.use(). 
The absolute path to the assets folder is __dirname + /public.
Now your app should be able to serve a CSS stylesheet. From outside, 
the public folder will appear mounted to the root directory. 
Your front-page should look a little better now! */

app.use(express.static(__dirname + "/public"));


// Implement a Root-Level Request Logger Middleware

app.use(function middleware(req, res, next){
  console.log(req.method + " " + req.path + " - " + req.ip);
  next();
});



/* Serve JSON on a Specific Route */ 

app.get("/json", (req, res) => {
  
    var myMessage = "Hello json";

    if(process.env.MESSAGE_STYLE=="uppercase"){
      return res.json({message:myMessage.toUpperCase()});
    }else{
      return res.json({message:myMessage})
    }
});




// console.log("Hello World");

/* app.get("/", function(req, res) {
  res.send("Hello Express");
}); */

app.get("/", (req,res) => {
  res.sendFile(__dirname + "/views/index.html");
 })




 module.exports = app;

