function text = GetText(image, key)

    binaryText='';
    step = 1;a=1;b=1;
    textLength=length(key);
      while (a<=256) && (step<=textLength)
        
        while (b<=256) && (step<=textLength)
            bloc = image(a:a+7, b:b+7);
            bloc = dct(bloc);

            p1 = bloc(key(step,1), key(step,2));
            p2 = bloc(key(step,3), key(step,4));
            diff = p2 - p1;

        if diff>0
            binaryText(step) = '1';
        else
            binaryText(step) = '0';
        end

            step = step + 1;
           b=b+8;
        end
        b=1;
        a=a+8;
        
      end
    text = bin2text(binaryText);
    % text = binaryText;
 % text=char(bin2dec(binaryText));
end

