﻿using System;
using System.Collections.Generic;
using System.Data;

using DTO;
using DAO;

namespace BUS
{
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodBUS();
                return FoodBUS.instance;
            }
        }

        private FoodBUS() { }

        public DataTable GetAllFood()
        {
            try
            {
                return FoodDAO.Instance.GetAllFood();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Food> GetFoodByCategoryID(int id)
        {
            try
            {
                return FoodDAO.Instance.GetFoodByCategoryID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Food> GetListFood()
        {
            try
            {
                return FoodDAO.Instance.GetListFood();
            }
            catch (Exception ex) {
            throw ex;}

        }

        public DataTable GetListFoodByCategoryID(int categoryID)
        {
            try
            {
                return FoodDAO.Instance.GetListFoodByCategoryID(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Food> SearchFoodByName(string name)
        {
            DataTable table;
            try
            {
                table = FoodDAO.Instance.SearchFoodByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Food> lstFood = new List<Food>();
            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row);
                lstFood.Add(food);
            }
            return lstFood;
        }

        public bool InsertFood(Food newFood)
        {
            return FoodDAO.Instance.InsertFood(newFood);
        }

        public bool UpdateFood(Food food)
        {
            return FoodDAO.Instance.UpdateFood(food);
        }

        public bool DeleteFood(int ID)
        {
            return FoodDAO.Instance.DeleteFood(ID);
        }
    }
}