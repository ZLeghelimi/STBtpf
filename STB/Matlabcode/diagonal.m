function refs = diagonal(mat)
%0
%bloc = img(8*9:8*9+7, 8*4:8*4+7);
%mat = double(bloc);
    idx=[];
    dists=[];

    % chercher dans les diags
    for k=8:-1:5

        diag=[];
        for i=1:8
            for j=1:8
                if(i+j == k)
                    diag(end+1)=mat(i,j); 
                    
                    
                end
            end
        end
        diag;
        mindist = 999999999;%max
        i1 = 1;
        i2 = 2;
        for x=1:length(diag)-1
            for y=x+1:length(diag)
                dis = abs(diag(x)-diag(y));
                if dis < mindist
                    i1 = x;
                    i2 = y;
                    mindist = dis;
                end
            end
        end
        %               ---p1---  ---p2---
        idx(end+1,:) = [i1 (k-i1) i2 (k-i2)];
        dists(end+1) = mindist;
    end

    m = find(dists == min(dists));
    refs = idx(m(1),:);

end

