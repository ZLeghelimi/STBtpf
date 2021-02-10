clear;

load('file.mat')

text2=PatchExtra(imageCover,stegoImg);
fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\outputs.txt','wt');
fprintf(fid, text2);
fclose(fid);
