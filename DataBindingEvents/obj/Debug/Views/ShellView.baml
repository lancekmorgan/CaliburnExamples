   M S B A M L   `   `   `  ����  
CaliburnEx!    DataBindingEvents.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QCaliburn.Micro, Version=1.5.2.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5   	   .��5      � 
�������.+�5   
   A�   A� Columns$  3��6   $	��Top=�6"   .+�5	      �� -   5        $��DecrementCount��5	      $��	Decrement��6+   $��15q�6?   �� 5
      -   5        $��delta��5
       � Minimum$ 0Q�6"    � Maximum$ 5Q�6.   $��15q�6:   �� 5      -   5        $��IncrementCount��5      $��	Increment��6+   $��15q�6?   5      �� 5   
   $��Hello Caliburn Micro!��6   $��Center=�61   $��Center=�6L   $��20(�6i   �� 5   
   -   5        $��Count��5      $��20q�6!   $	��150(�6-   $��Bottom=�6<   $��Center=�6W   
����ح�$	��175��6�   6�   �� 5   
   $��+��6   $��15(�6#   $��	0,0,70,15q�61   $��Bottom=�6D   $��Right=�6_   $��50��6{   $��30��6�     Caliburn.Micro.Message   Attach$0 *[Event Click] = [Action IncrementCount(1)]��6�   6�   �� 5   
   $	��+10��6   $��15(�6%   $��15q�63   $��Bottom=�6?   $��Right=�6Z   $��50��6v   $��30��6�   $1 +[Event Click] = [Action IncrementCount(10)]��6�   6�   �� 5   
   $��-��6   $��15(�6#   $��	70,0,0,15q�61   $��Bottom=�6D   $
��Left=�6_   $��50��6z   $��30��6�   $0 *[Event Click] = [Action DecrementCount(1)]��6�   6�   �� 5   
   $	��-10��6   $��15(�6%   $��15q�63   $��Bottom=�6?   $
��Left=�6Z   $��50��6u   $��30��6�   $1 +[Event Click] = [Action DecrementCount(10)]��6�   6�   �� 5   
   $��Double��6   $��15(�6(   $��	0,0,15,50q�66   $��Bottom=�6I   $��Right=�6d   $	��105��6�   $��30��6�   $9 3[Event Click] = [Action IncrementCount(Count.Text)]��6�   �� 5   
   $
��Zero��6   $��15(�6&   $��	15,0,0,50q�64   $��Bottom=�6G   $
��Left=�6b   $	��105��6}   $��30��6�   $9 3[Event Click] = [Action DecrementCount(Count.Text)]��6�   5F      5K      