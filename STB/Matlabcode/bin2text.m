function text = bin2text(bintext)
    n = length(bintext);
    text ='';
    for i = 1:8:n
        l = '';
        lettre = bintext(i:i+7);
        for j=1:8
            l = strcat(l,lettre(j));
        end
        text = strcat(text, char(bin2dec(l)));
    end
end

