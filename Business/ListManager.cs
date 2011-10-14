﻿using System.Collections.Generic;
using Common;
using Data;

namespace Business
{
	public interface IListManager
	{
		IEnumerable<Item> GetListItems(int listId);
		IEnumerable<UserList> GetUserLists(string userName);
		void AddNewList(string userName, string newListName);
		void DeleteList(int userListId);
		void AddItemToList(int userListId, string listItem);
		void DeleteItem(int itemId);
		UserList GetList(int userListId);
		void SaveChanges(int userListId, string newTitle, string newDescription);
	}

	public class ListManager : IListManager
	{
		public IEnumerable<Item> GetListItems(int listId)
		{
			return new ListDAO().GetListItems(listId);
		}

		public IEnumerable<UserList> GetUserLists(string userName)
		{
			return new ListDAO().GetUserLists(userName);
		}

		public void AddNewList(string userName, string newListName)
		{
			new ListDAO().AddNewList(userName, newListName);
		}

		public void DeleteList(int userListId)
		{
			new ListDAO().DeleteList(userListId);
		}

		public void AddItemToList(int userListId, string listItem)
		{
			new ListDAO().AddItemToList(userListId, listItem);
		}

		public void DeleteItem(int itemId)
		{
			new ListDAO().DeleteItem(itemId);
		}

		public UserList GetList(int userListId)
		{
			return new ListDAO().GetList(userListId);
		}

		public void SaveChanges(int userListId, string newTitle, string newDescription)
		{
			new ListDAO().SaveChanges(userListId, newTitle, newDescription);
		}
	}
}