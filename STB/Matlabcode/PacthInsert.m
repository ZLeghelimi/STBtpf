te = fileread('inputs.txt');
te=te(4:length(te));

save('file.mat','te');

imgCpath = fileread('filepath.txt');
imgCpath=imgCpath(4:length(imgCpath));

imageCover=imread(imgCpath);

stegoImg=PatchInsert(imageCover,te);

save('file.mat','stegoImg','imageCover');

