imgHpath = fileread('inputs.txt');
imgHpath=imgHpath(4:length(imgHpath));

imgorigine=imread(imgHpath);
imgorigine=rgb2gray(imgorigine);
stego=imread('C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png');

mse=mse(imgorigine,stego);
psnr=psnr(imgorigine,stego,mse);
%h=h(stego);

fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\psnr.txt','wt');
fprintf(fid,psnr);
fclose(fid);

fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\mse.txt','wt');
fprintf(fid,mse);
fclose(fid);

%fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\h.txt','wt');
%fprintf(fid,h);
%fclose(fid);


