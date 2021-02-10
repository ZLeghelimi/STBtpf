%aa=imread('stego.png');
x=uint8(st);

imwrite(x,'C:\Users\zinou\source\repos\STB\STB\Matlabcode\stegoma.png');

txt=getText(st,key);

fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\outputs.txt','wt');
fprintf(fid, txt);
fclose(fid);