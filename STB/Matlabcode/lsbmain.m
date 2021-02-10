text = fileread('inputs.txt');
text=text(4:length(text));

path = fileread('filepath.txt');
path=path(4:length(path));

lsb(text,path);