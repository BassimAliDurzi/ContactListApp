   M S B A M L   `   `   `  ����M  IContactListMainApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ContactListMainApp.ViewsContactListMainApp.Views  5      M+clr-namespace:ContactListMainApp.ViewModelsContactListMainApp.ViewModels  5      C ?Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC/clr-namespace:Business.Models;assembly=BusinessBusiness.Models 5      -    'ContactListMainApp.Views.AddContactView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:ContactListMainApp.Views     5      B
viewmodles+clr-namespace:ContactListMainApp.ViewModels     5      Bmodels/clr-namespace:Business.Models;assembly=Business     5      
�������.��5      � $��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Create New Contact��6!   $��Center=�6;   $��20(�6X   $
��Bold"�6f   �� 5!   
   $��1��6   $	��0 5q�6"   .+�5"      �� $�� First Name��6   $
��Left=�6*   $��Center=�6E   $��10q�6`   $
��Bold"�6m   �� 5#      -   5         ��Name$ 	FirstName��5#   9   $��7q�6L   $	��400��6Y   $��30��6e   $��Center=�6r   $��Center=�6�   ��6   �� *Contact.FirstName+6�   5$      �� 5%   
   $��2��6   $	��0 5q�6"   .+�5&      �� $��
 Last Name��6   $
��Left=�6)   $��Center=�6D   $��10q�6_   $
��Bold"�6l   �� 5'      -   5        $ LastName��5'   8   $��7q�6J   $	��400��6V   $��Center=�6b   $��Center=�6   ��6   �� *Contact.LastName+6   5(      �� 5)   
   $��3��6   $	��0 5q�6"   .+�5*      �� $�� Email��6   $
��Left=�6%   $��Center=�6@   $��10q�6[   $
��Bold"�6h   �� 5+      -   5        $ Email��5+   5   $��7q�6D   $	��400��6P   $��Center=�6\   $��Center=�6y   ��6   �� *Contact.Email+6y   5,      �� 5-   
   $��4��6   $	��0 5q�6"   .+�5.      �� $��
 Phone No.��6   $
��Left=�6)   $��Center=�6D   $��10q�6_   $
��Bold"�6l   �� 5/      -   5        $ PhoneNumber��5/   ;   $��7q�6P   $	��400��6\   $��Center=�6h   $��Center=�6�   ��6   �� *Contact.PhoneNumber+6�   50      �� 51   
   $��5��6   $	��0 5q�6"   .+�52      �� $�� Street��6   $
��Left=�6&   $��Center=�6A   $��10q�6\   $
��Bold"�6i   �� 53      -   5        $ Street��53   6   $��7q�6F   $	��400��6R   $��Center=�6^   $��Center=�6{   ��6   �� *Contact.Street+6{   54      �� 55   
   $��6��6   $	��0 5q�6"   .+�56      �� $�� Postal Code��6   $
��Left=�6+   $��Center=�6F   $��10q�6a   $
��Bold"�6n   �� 57      -   5        $ 
PostalCode��57   :   $��7q�6N   $	��400��6Z   $��Center=�6f   $��Center=�6�   ��6   �� *Contact.PostalCode+6�   58      �� 59   
   $��7��6   $	��0 5q�6"   .+�5:      �� $�� City��6   $
��Left=�6$   $��Center=�6?   $��10q�6Z   $
��Bold"�6g   �� 5;      -   5        $
 City��5;   4   $��7q�6B   $	��400��6N   $��Center=�6Z   $��Center=�6w   ��6   �� *Contact.City+6w   5<      �� 5>   
   $��8��6   $	��0 5q�6"   .+�5?      �� $	��300��65   $��8q�6A   $��0, 30, 0 , 20q�6M   $
��Save��6d   
���/���$
��Bold"�6�    � Cursor$
 Hand��6�   $��0,0,0,0q�6�   ��6   �� *SaveCommand+��6�   Z� �� 5@      $	��300��6   $��8q�6!   $��Cancel��6-   $
��Bold"�6g   
����ح�$��0,0,0,0q�6�   ���	#FF707070$
 Hand��6�   ��6>   �� *GoToContactsCommand+6�   5A      5E      5G      