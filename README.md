# SigTool
![image.png](https://s31.postimg.cc/9ekrz81zv/image.png)

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

![image.png](https://s18.postimg.cc/p70lf08mh/image.png)


![image.png](https://s18.postimg.cc/jk48h6iux/image.png)

![image.png](https://s18.postimg.cc/lbx7c44sp/image.png)

#### .st Files

When the \[save\] button is clicked, sigs are saved in a file with the following format:


```xml
<SigScan>
  <process>starwarsbattlefrontii</process>
  <Sig>
    <name>OFFSET_ClientGameContext</name>
    <data>\x48\x89\x15\x00\x00\x00\x00\x48\x89\xcb</data>
    <mask>xxx????xxx</mask>
    <func>False</func>
  </Sig>
  <Sig>
    <name>OFFSET_GameRenderer</name>
    <data>\x48\x8b\x0d\x00\x00\x00\x00\x48\x85\xc9\x74\x0b\x48\x8b\x01\xba\x00\x00\x00\x00\xff\x50\x68</data>
    <mask>xxx????xxxxxxxxx????xxx</mask>
    <func>False</func>
  </Sig>
  <Sig>
    <name>OFFSET_FirstTypeInfo</name>
    <data>\x48\x8b\x05\x00\x00\x00\x00\x48\x89\x41\x08\x48\x89\x0d\x00\x00\x00\x00</data>
    <mask>xxx????xxxxxxx????</mask>
    <func>False</func>
  </Sig>
  <Sig>
    <name>OFFSET_DXRenderer</name>
    <data>\x48\x8b\x0d\x00\x00\x00\x00\x48\x8b\x01\xff\x50\x20\x85\xc0</data>
    <mask>xxx????xxxxxxxx</mask>
    <func>False</func>
  </Sig>
  <Sig>
    <name>OFFSET_Main</name>
    <data>\x48\x8b\x05\x00\x00\x00\x00\x48\x63\x58\x40\xe8\x00\x00\x00\x00\x48</data>
    <mask>xxx????xxxxx????x</mask>
    <func>False</func>
  </Sig>
</SigScan>
```

The clipboard contents after clicking \[Copy Output\] is in the 
following format:

```c++
#define OFFSET_ClientGameContext 0x14428A188
#define OFFSET_GameRenderer 0x1444F90C8
#define OFFSET_FirstTypeInfo 0x143FAEBD8
#define OFFSET_DXRenderer 0x1444F7150
#define OFFSET_Main 0x143FAE5C8
```
