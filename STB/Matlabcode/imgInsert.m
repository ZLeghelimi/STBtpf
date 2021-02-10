function [img]=imgInsert(imageHaute,imageSecrete)

N=8;

[s,t]=size(imageHaute);

for i=1:s
    for j=1:t
        v1=[];
        v2=[];
        
       asciImgCouv=dec2bin(imageHaute(i,j));
       asciImgSec=dec2bin(imageSecrete(i,j));
       
       for p=1:numel(asciImgCouv)
           v1=[v1 str2double(asciImgCouv(p))];    
       end
       
       for f=1:numel(asciImgSec)
          v2=[v2 str2double(asciImgSec(f))];
          
       end
       
       str=zeros(1,8-length(v1));
       v1=[str v1];
       strr=zeros(1,8-length(v2));
       v2=[strr v2];
       A=[];
       B=[];
       
       for l=1:N/2
           A=[A v1(l)];
           B=[B v2(l)];
       end
       asci_couv_cach=[A B];
       asci_couv_cach=int2str(asci_couv_cach);
       im(i,j)=bin2dec(asci_couv_cach);
    end
end
i=uint8(im);
img=i;    
end