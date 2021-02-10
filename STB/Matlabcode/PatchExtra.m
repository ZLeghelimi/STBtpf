function [ msg ] = PatchExtra( img,key )
msg = '';
    % Récuperer toutes les n paires grâce à la clé secrète. 
for k=1:1:size(key,2)
    
    %Pour chaque paire calculer la différence entre les pixels     
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


