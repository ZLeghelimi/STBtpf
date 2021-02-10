imgHpath = fileread('inputs.txt');
imgHpath=imgHpath(4:length(imgHpath));

imgCpath = fileread('filepath.txt');
imgCpath=imgCpath(4:length(imgCpath));

imageHauteR=imread(imgHpath);
imageSecreteR=imread(imgCpath);

imageHaute=rgb2gray(imageHauteR);
imageSecrete=rgb2gray(imageSecreteR);

stegoImg=imgInsert(imageHaute,imageSecrete);

imwrite(stegoImg,'C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png');

mse=mse(imageHaute,stegoImg);
psnr=psnr(imageHaute,stegoImg,mse);
h=h(stego);



