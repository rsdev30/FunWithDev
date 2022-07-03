'use strict';
const http = require('http');
const fs = require('fs')
var port = process.env.PORT || 1337;

http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/html' });    
    fs.createReadStream('index.html').pipe(res)
}).listen(port);
