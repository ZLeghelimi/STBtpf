function a=lsb(tx,path)
% Partie emetteur

imgcover=imread(path);
initimg=imgcover;

r=imgcover(:,:,1);
b=imgcover(:,:,3);


x = tx;

sr=size(r);
sb=size(b);

ri=sr(1);
bi=sb(1);


msgsize=length(x);

keyir=randi(ri,[msgsize 4]);
keyib=randi(bi,[msgsize 4]);



ascii =uint8(x);

for i=1:msgsize
    xMsg=binaireVector(ascii(i));
    
    m11=binaireVector(r(i,keyir(1)));
    m12=binaireVector(r(i,keyir(2)));
    m13=binaireVector(r(i,keyir(3)));
    m14=binaireVector(r(i,keyir(4)));
    
    
    m21=binaireVector(b(i,keyib(1)));
    m22=binaireVector(b(i,keyib(2)));
    m23=binaireVector(b(i,keyib(3)));
    m24=binaireVector(b(i,keyib(4)));
    
    
    [partie1,partie2]=divMsg(xMsg);
    
    p11=partie1(1);
    p12=partie1(2);
    p13=partie1(3);
    p14=partie1(4);
    
    p21=partie2(1);
    p22=partie2(2);
    p23=partie2(3);
    p24=partie2(4);
     
    
    %p111=m1(1:4);
    %p112=m2(1:4);
    
    p1111=m11(1:7);
    p1112=m12(1:7);
    p1113=m13(1:7);
    p1114=m14(1:7);
    
    p2111=m21(1:7);
    p2112=m22(1:7);
    p2113=m23(1:7);
    p2114=m24(1:7);
     
    f11=[p1111 partie1(4)];
    f12=[p1112 partie1(3)];
    f13=[p1113 partie1(2)];
    f14=[p1114 partie1(1)];
    
    f21=[p2111 partie2(4)];
    f22=[p2112 partie2(3)];
    f23=[p2113 partie2(2)];
    f24=[p2114 partie2(1)];
    
    
    msgr1=bin2dec(int2str(f11));
    msgr2=bin2dec(int2str(f12));
    msgr3=bin2dec(int2str(f13));
    msgr4=bin2dec(int2str(f14));
    
    msgb1=bin2dec(int2str(f21));
    msgb2=bin2dec(int2str(f22));
    msgb3=bin2dec(int2str(f23));
    msgb4=bin2dec(int2str(f24));
    
    %msgRed=int2str([p111 partie1]);
    %msgBlue=int2str([p112 partie2]);
    
    %msgRed=bin2dec(msgRed);
    %msgBlue=bin2dec(msgBlue);
    
    

    r(i,keyir(1))=msgr1;
    r(i,keyir(2))=msgr2;
    r(i,keyir(3))=msgr3;
    r(i,keyir(4))=msgr4;
   
    b(i,keyib(1))=msgb1;
    b(i,keyib(2))=msgb2;
    b(i,keyib(3))=msgb3;
    b(i,keyib(4))=msgb4;
   
    
    %r((i))=msgRed;
    %b((i))=msgBlue;
   
end

  imgcover(:,:,1)=(r);
  imgcover(:,:,3)=(b);
  
 imwrite(imgcover,'C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png');

   
%Partie recepteur

rr = imgcover(:,:,1); 
rb = imgcover(:,:,3);

mesextr=[];
for i=1:length(x)
    
    pr11=binaireVector(rr(i,keyir(1)));
    pr12=binaireVector(rr(i,keyir(2)));
    pr13=binaireVector(rr(i,keyir(3)));
    pr14=binaireVector(rr(i,keyir(4)));
    
    pr21=binaireVector(rb(i,keyib(1)));
    pr22=binaireVector(rb(i,keyib(2)));
    pr23=binaireVector(rb(i,keyib(3)));
    pr24=binaireVector(rb(i,keyib(4)));
    
    prt1=[pr14(8) pr13(8) pr12(8) pr11(8)];
    prt2=[pr24(8) pr23(8) pr22(8) pr21(8)];
   
    
    msg=[prt1 prt2];
    
    msg_n=int2str(msg);
    
    msg_n=bin2dec(msg_n);
    mesextr=[mesextr msg_n];
    
end


mesextr=char(mesextr)


fid = fopen('C:\Users\zinou\source\repos\STB\STB\Matlabcode\outputs.txt','wt');
fprintf(fid, mesextr);
fclose(fid);



end