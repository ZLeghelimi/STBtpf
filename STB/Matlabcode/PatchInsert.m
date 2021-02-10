function [ Clef_extr ] = PatchInsert(img,msg)

seuil = 20; % pr�d�finir le seuil
msg_bin = str(msg)
key = randi(size(img,1),4,length(msg)*500); % g�n�rer la suite de bits de mani�re pseudo al�toire
k = 1;
Clef_extr = [];
i = 1;
while(size(Clef_extr,2)<size(msg_bin,2)) % Pour chaque paire, 
       posx1=key(1,k);
       posy1=key(2,k);
       posx2=key(3,k);
       posy2=key(4,k);
      
        d = img(posx1,posy1)- img(posx2,posy2); %calculer la diff�rence d entre les 2 pix 
        %Coder un  bit d�information dans chaque paire 
        bit = '0';
        
        if(abs(d)<seuil && d~=0 ) 

            if(d>0)  %d > 0 repr�sente 1 et d < 0 repr�sente 0 et
                bit = '1';
            end
        
            cle = key(:,k)';
            pair = permuter(key(:,k),bit==msg_bin(i));% Si les pixels sont dans le mauvais ordre, les permuter. 
           
            Clef_extr(:,i)= pair;
            i=i+1;
        end
        % else �carter la paire et passer � la suivante.
        k=k+1;
        disp('k')
        disp(k);
        
end
end

% % % % % % *************** permuter function**************
function pair = permuter (p,bool)
if(bool==1)
    pair(1) = p(1,1);
    pair(2) = p(2,1);
    pair(3) = p(3,1);
    pair(4) = p(4,1);
else
    pair(1) = p(3,1);
    pair(2) = p(4,1);
    pair(3) = p(1,1);
    pair(4) = p(2,1);
    
end
end

function res = str(c)
    res ='';
    s = dec2bin(c,8);
    for i=1:size(s,1)
        res = [res s(i,:)];
    end
end


