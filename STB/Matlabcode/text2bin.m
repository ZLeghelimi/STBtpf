function bintxt = text2bin(text)
    bintxt = '';
    dectxt = double(text);
    bin = dec2bin(dectxt,8);
    s = size(bin);
    for i=1:s(1)
        bintxt = strcat(bintxt, bin(i,:));
    end
end

