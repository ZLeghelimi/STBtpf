function imgSecrete=extrImg(imgStego)
clc
h=8

[s,t]=size(imgStego);
for i=1:s
    for j=1:t
      v3=[];
      im_ascii  =dec2bin(imgStego(i,j))
      for p=1:numel(im_ascii)
           v3=[v3 str2double(im_ascii(p))];
      end
       strr=zeros(1,8-length(v3));
       v3=[strr v3]
       C=[];
       for ll=5:h
           C=[C v3(ll)];
       end
       st=zeros(1,4)
       image=[C st]
       image=int2str(image)
       ima(i,j)=bin2dec(image);
       
    end
end
ii=uint8(ima);
imgSecrete=ii;



end

