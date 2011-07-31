{\rtf1\ansi\ansicpg1252\cocoartf949\cocoasubrtf540
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
\margl1440\margr1440\vieww16880\viewh13300\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\ql\qnatural\pardirnatural

\f0\fs24 \cf0 % Caleb Wherry\
% September 21st, 2009\
%\
% juliaset_4d.m\
%\
% Function Form:\
% f(z) = z*z + c where z,c are quaternion (hypercomplex) values.\
%\
% Normal calling sequence:\
% W = juliaset_4d;\
%\
% Arguments are as follows:\
%   REAL       : Real part of z.\
%   IMAG1      : i Imaginary part of z.\
%   IMAG2      : j Imaginary part of z.\
%   IMAG3      : k Imaginary part of z.\
%   R_SIZE     : R grid size.\
%   I_SIZE     : I grid size.\
%   J_SIZE     : J grid size.\
%   K_SIZE     : K grid size.\
%   MAX_IT     : Maximum number of iterations allowed.\
%   THRESHOLD  : Threshhold for stopping calculations (divergence).\
%   PRINT      : Display graph: 0 = no, 1 = yes\
\
function H=juliaset_4d_2\
\
  real = -1.0; \
  imag1 = 0.2;\
  imag2 = 0.0;\
  imag3 = 0.0;\
  r_size = 10; \
  i_size = 10;\
  j_size = 10;\
  k_size = 10;\
  max_it = 256;\
  threshold = 4.0;\
  print = 0;\
  \
  % Grid to graph on:\
  R = linspace( -0.5, 0.5, r_size);\
  I = linspace( -0.5, 0.5, i_size);\
  J = linspace( -0.5, 0.5, j_size);\
  K = linspace( -0.5, 0.5, k_size);\
  \
  % 4D grid:\
  %H = ndgrid(R,I,J,K);\
  H = zeros(r_size,i_size,j_size,k_size);\
\
  % Quaternion constant in f(z):\
  c = quaternion(real,imag1,imag2,imag3);\
\
  % open matlabpool:\
  matlabpool open;\
      \
    spmd\
\
      % Distribute matrices across workers:\
      H = codistributed(H, 'convert');\
      LH = localPart(H);\
      \
      % Loop through and do calculations on each point:\
      for r = 1:size(LH,1)\
        for i = 1:size(LH,2)\
          for j = 1:size(LH,3)\
            for k = drange(1:size(LH,4))\
\
              % Intialize number of iterations:\
              num = 0;\
              \
              % Quaternion value of the current coordinate point:\
              Q = quaternion( R(r), I(i), J(j), K(k) );\
              %Q = quaternion(r,i,j,k);\
            \
              % Calculate value of F(z) at above z:\
              Q1 = Q*Q + c;\
\
              % Take magnitude of the above value (z1):\
              mag = abs(Q1*Q1 + c);\
            \
              % Do loop until mag is greater than threshold or max iterations have been calculated:\
              while ((mag < threshold) && (num < max_it))\
 \
                % Re-Calculate value of F(z) at above z1:\
                Q1 = Q1*Q1 + c;\
\
                % Take magnitude of the above value (z1):\
                mag = abs(Q1*Q1 + c);\
 \
                % Increment iteration variable:\
                num = num+1;\
\
              end\
 \
              % Value of matrix is set to iteration number:\
              LH(r,i,j,k) = num;\
              \
            end\
          end\
        end\
      end\
      \
      H = codistributed(LH, 'convert');\
      H = gather(H);\
      \
    end\
    \
    % Gather array back into its components:\
    H = H\{1\};\
    \
  % Close matlab parallel:\
  matlabpool close;\
   \
  % Graph data:\
%  if print == 1\
%      \
%    W = H(1,:,:,:);\
%    W = squeeze(W);\
%      \
%    % Somehow graph a 3D slice of W...???\
%    % How it would be in 2D:\
%    colormap jet;\
%    pcolor(W);\
%    shading flat;\
%  end\
  \
end}