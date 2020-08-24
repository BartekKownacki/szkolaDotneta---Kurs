using System;
using System.Collections.Generic;


namespace HospitalManager
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;
        public MenuActionService()
        {
            menuActions = new List<MenuAction>();
        }

        public void AddNewAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction() { Id = id, Name = name, MenuName = menuName };
            menuActions.Add(menuAction);
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> filteredMenuActions = new List<MenuAction>();
            foreach(var menuAction in menuActions)
            {
                if(menuAction.MenuName==menuName)
                {
                    filteredMenuActions.Add(menuAction);
                }
            }
            return filteredMenuActions;
        }

    }
}
