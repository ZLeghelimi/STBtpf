function [ msg ] = PatchExtra( img,key )
msg = '';
    % R�cuperer toutes les n paires gr�ce � la cl� secr�te. 
for k=1:1:size(key,2)
    
    %Pour chaque paire calculer la diff�rence entre les pixels     
    diff = img(key(1,k),key(2,k))-img(key(3,k),key(4,k));
    if(diff>0)
        msg = [msg,'1'];
    else 
                msg = [msg,'0']; 
    end
end
  %reconstruire le msg
    ms =char(bin2dec(vec2mat(msg,8)));
   
    msg = strcat(ms(:,1)');
    
    end


