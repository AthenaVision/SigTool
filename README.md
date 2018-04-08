# SigTool
![image.png](https://s31.postimg.org/l2ettlr2z/image.png)

Utility for scanning signatures, as well as 
converting them between different formats.  

### Goal:

Rather than eight and a half million sig scanning utilities out there, 
each built for a specifically targetted game, with hardcoded sigs, 
this utility aims to modularize all of that.  Scanning signatures 
has never been easier, and the .st files created by this allow for 
anyone to distrubute different signatures with ease.

### SigTool

Works on x64.  Actual sig scanning is performed in the background, 
and updaded asynchronously to the UI.

The \[Is Function\] switch returns the address of the actual 
byte array, otherwise the address will be returned like such:

```nasm
mov rax, [143fae5c8] ;  mov register, [rip + offset]
```

Supports custom files that can be opened (both manually and just by 
associating SigTool with) that save the process name, sig names, and the 
sigs themselves.

[![image.png](https://s18.postimg.org/p70lf08mh/image.png)](https://postimg.org/image/5p5xz2bol/)


[![image.png](https://s18.postimg.org/jk48h6iux/image.png)](https://postimg.org/image/4beb3ep6d/)

[![image.png](https://s18.postimg.org/lbx7c44sp/image.png)](https://postimg.org/image/50x3fssat/)

