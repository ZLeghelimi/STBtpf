text = fileread('inputs.txt');
text=text(4:length(text));

path = fileread('filepath.txt');
path=path(4:length(path));


img=imread(path);

[st,key]=zhao(img,text);

imwrite(st,'C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png');
