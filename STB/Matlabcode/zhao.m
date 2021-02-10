function [image, key] = zhao(image, text)
   % image=imread('cama.jpg');
    binaryText = text2bin(text);
    textLength= length(binaryText);
    image = double(image);
    step= 1;
    key = [];a=1;b=1;
    while (a<=256) && (step<=textLength)
        
        while (b<=256) && (step<=textLength)
            
            bloc = image(a:a+7, b:b+7);         
           
            mat = dct(bloc);
            refs = diagonal(mat);
            key(step,:) = refs;
            p1 = mat(refs(1), refs(2));
            p2 = mat(refs(3), refs(4));
            bit = str2num(binaryText(step));
            diff = p2 - p1;
            if(bit==0)
                while(diff > 0)
                    p2 = p2 - 1;
                    diff = p2 - p1;
                end
            else
                while(diff <= 0)
                    p2 = p2 + 1;
                    diff = p2 - p1;
                end
            end

            mat(key(step,3), key(step,4)) = p2;
            % calculer la DCT inverse 
            ibloc = idct(mat);
            image(a:a+7, b:b+7) = ibloc;
            %image = uint8(image);

            step = step + 1;
            
           b=b+8;
        end
        b=1;
        a=a+8; 
        %imshow(uint8(image))
    end
%end

