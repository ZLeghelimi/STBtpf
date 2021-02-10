function [p1,p2]=divMsg(msg)
p1=[];
p2=[];
v=msg;
l=length(msg);
p1=msg(1:l/2);
p2=msg(((l/2)+1):l);
end