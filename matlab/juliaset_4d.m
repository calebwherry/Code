% Caleb Wherry
% September 21st, 2009
%
% juliaset_4d.m
%
% Function Form:
% f(z) = z*z + c where z,c are quaternion (hypercomplex) values.
%
% Normal calling sequence:
% grid_4d = juliaset_4d (0.0, 0.0, 0.0, 0.0, 10, 10, 10, 10, 50.0, 256, 0.50)
%
% Arguments are as follows:
%   REAL       : Real part of z.
%   IMAG1      : i Imaginary part of z.
%   IMAG2      : j Imaginary part of z.
%   IMAG3      : k Imaginary part of z.
%   R_SIZE     : R grid size.
%   I_SIZE     : I grid size.
%   J_SIZE     : J grid size.
%   K_SIZE     : K grid size.
%   MAX_IT     : Maximum number of iterations allowed.

function W = juliaset_4d (real, imag1, imag2, imag3, r_size, i_size, j_size, k_size, max_it)
  
  % Grid to graph on:
  R_SIZE = linspace( -1.5,1.5,r_size);
  I_SIZE = linspace( -1.5,1.5,i_size);
  J_SIZE = linspace( -1.5,1.5,j_size);
  K_SIZE = linspace( -1.5,1.5,k_size);
  
  % Create a 4D mesh somehow...???
  [R,X,Y,Z] = meshgrid(R_SIZE,I_SIZE, J_SIZE, K_SIZE);

  % 4D matrix to hold all quaternions on grid:
  Z = quaternion(R,X,Y,Z);
  
  % Quaternion constant in f(z):
  c = quaternion(real,imag1,imag2,imag3);
  
  for i=1:max_it
    Z=Z*Z + c;
  end

  W = exp(-abs(Z));
  
  % Somehow graph a 3D slice of W...???
  % How it would be in 2D:
  colormap jet;
  pcolor(W);
  shading flat;
  
  
%%%%%% OLD CODE %%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%
%   % Scale factor for graphing:
%   SCALE = scale;
% 
%   % Offsets for centering graph around the origin:
%   R_OFFSET = fix(r_size/2.0);
%   I_OFFSET = fix(i_size/2.0);
%   J_OFFSET = fix(j_size/2.0);
%   K_OFFSET = fix(k_size/2.0);
% 
%   % Scale function values to be within [0,1] and possibly
%   % have a scaling factor in case not all of graph is displayed
%   % when graphed.
%   R_SCALE = fix(R_OFFSET*SCALE);
%   I_SCALE = fix(I_OFFSET*SCALE);
%   J_SCALE = fix(J_OFFSET*SCALE);
%   K_SCALE = fix(K_OFFSET*SCALE);

  % Loop through and do calculations on each point:
  % ** This needs to be changed to take advantage of matrix multiplications
  %    which I do not fully know how to do at the moment! **
%   for r=1:r_size   
%     for i=1:i_size 
%       for j=1:j_size
%         for k=1:k_size
%             
%           % Intialize number of iterations:
%           num = 0;
%           
%           % Intialize magnitude:
%           mag = 0.0;
%       
%           % Complex value of the current coordinate point:
%           z = quaternion( double(r-R_OFFSET)/R_SCALE, double(i-I_OFFSET)/I_SCALE, double(j-J_OFFSET)/J_SCALE, double(k-K_OFFSET)/K_SCALE );
% 
%           % Calculate value of F(z) at above z:
%           z = z*z + c;
%       
%           % Take magnitude of the above value (z):
%           mag = norm(z);
% 
%           % Do loop until mag is greater than threshold or max iterations have
%           % been calculated:
%           while ((mag <= THRESH) && (num < MAX_ITERATION))
% 
%             % Re-Calculate value of F(z) at above z:
%             z = z*z + c;
% 
%             % Take magnitude of the above value (z):
%             mag = norm(z);
% 
%             % Increment iteration variable:
%             num = num + 1;
% 
%           end
% 
%           % Value of matrix is set to iteration number:
%           grid_4d(r,i,j,k) = num;
%         
%         end
%       end
%     end
%   end
  
end