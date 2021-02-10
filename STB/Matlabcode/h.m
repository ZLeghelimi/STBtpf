function z=h(img)

s=0;

img=double(img);

[m,n]=size(img);

for i=1:m

    for j=1:n

        s=img(i,j)+s;

    end

end

z=-(s*log2(s));
end