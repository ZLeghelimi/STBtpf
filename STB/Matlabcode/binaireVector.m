function p=binaireVector(x)
p=[];
x=dec2bin(x);
 for i=1:length(x);
     p=[p str2double(x(i))];
 end
 length(p);
 str=zeros(1,8-length(p));
 p=[str p];
end