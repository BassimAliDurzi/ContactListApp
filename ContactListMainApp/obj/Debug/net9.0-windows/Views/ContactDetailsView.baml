   M S B A M L   `   `   `  ����M  IContactListMainApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ContactListMainApp.ViewsContactListMainApp.Views  5      M+clr-namespace:ContactListMainApp.ViewModelsContactListMainApp.ViewModels  5      C ?Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC/clr-namespace:Business.Models;assembly=BusinessBusiness.Models 5      1    +ContactListMainApp.Views.ContactDetailsView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:ContactListMainApp.Views     5      B
viewmodles+clr-namespace:ContactListMainApp.ViewModels     5      Bmodels/clr-namespace:Business.Models;assembly=Business     5      
�������.��5      � $��20q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Contact Details��6!   $��Center=�69   $��20(�6V   $
��Bold"�6d   �� 5   
   $��1��6   $
��0 20q�6"   .+�5      �� $�� First Name��6   $
��Left=�6+   $��Center=�6F    �� Padding$ 10q�6a   $
��Bold"�6n   �� 5      $ 4q�6;   $	��380��6G   
������� �� TextAlignment$ Center=�6e   ��6   �� *Contact.FirstName+6e   �� 5      $��
 Last Name��6   $
��Left=�6*   $��Center=�6E   $ 10q�6`   $
��Bold"�6m   �� 5      $ 4q�6:   $	��380��6F   
�������$ Center=�6d   ��6   �� *Contact.LastName+6d   �� 5       $�� Email��6   $
��Left=�6&   $��Center=�6A   $ 10q�6\   $
��Bold"�6i   �� 5!      $ 4q�67   $	��380��6C   
�������$ Center=�6a   ��6   �� *Contact.Email+6a   �� 5#      $�� Phone Number��6   $
��Left=�6-   $��Center=�6H   $ 10q�6c   $
��Bold"�6p   �� 5$      $ 4q�6=   $	��380��6I   
�������$ Center=�6g   ��6   �� *Contact.PhoneNumber+6g   �� 5&      $�� Street��6   $
��Left=�6'   $��Center=�6B   $ 10q�6]   $
��Bold"�6j   �� 5'      $ 4q�68   $	��380��6D   
�������$ Center=�6b   ��6   �� *Contact.Street+6b   �� 5)      $�� Postal Code��6   $
��Left=�6,   $��Center=�6G   $ 10q�6b   $
��Bold"�6o   �� 5*      $ 4q�6<   $	��380��6H   
�������$ Center=�6f   ��6   �� *Contact.PostalCode+6f   �� 5,      $�� City��6   $
��Left=�6%   $��Center=�6@   $ 10q�6[   $
��Bold"�6h   �� 5-      $ 4q�66   $	��380��6B   
�������$ Center=�6`   ��6   �� *Contact.City+6`   5.      �� 50   
   $��2��6   .+�51      �� $
��Edit��6=   $	��380��6L   $��0, 10q�6Y   $��8q�6h   $
��Bold"�6u   
���/��� � Cursor$
 Hand��6�   $��0,0,0,0q�6�   ��6   �� *GoToEditViewCommand+��6�   Z� �� 52      $��Delete��6>   $	��380��6O   $��0, 10q�6[   $��8q�6j   $
��Bold"�6w   
���\\��$
 Hand��6�   $��0,0,0,0q�6�   ��6   �� *DeleteContactCommand+��6�   Z� �� 53      $��Cancel��67   $	��380��6H   $��0, 10q�6T   $��8q�6c   $
��Bold"�6p   
����ح�$
 Hand��6�   $��0,0,0,0q�6�   ��6   �� *CancelCommand+��6�   Z� 54      56      57      