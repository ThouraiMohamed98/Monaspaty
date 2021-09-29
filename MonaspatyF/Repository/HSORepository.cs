using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonaspatyF.Models;

namespace MonaspatyF.Repository
{
    public class HSORepository
    {
        private readonly MonaspatyContext db;
        public HSORepository(MonaspatyContext db)
        {
            this.db = db;
        }

        public List<HallShopOwner> getAllList()
        {
            return db.HallShopOwners.ToList();
        }

        public HallShopOwner getById(int? id)
        {
            return db.HallShopOwners.Where(n => n.Id == id).SingleOrDefault();
        }

        public void Update(HallShopOwner entity)
        {
            HallShopOwner hso = db.HallShopOwners.Where(n => n.Id == entity.Id).SingleOrDefault();
            hso.name  = entity.name;
            hso.phone = entity.phone;
            hso.email = entity.email;
            hso.SSN   = entity.SSN;
            hso.confirmPassword = hso.password;
            db.SaveChanges();
        }

        public void Add(HallShopOwner entity)
        {
            db.HallShopOwners.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            HallShopOwner hso = getById(id);
            db.HallShopOwners.Remove(hso);
            db.SaveChanges();
        }

        public HallShopOwner searchForLogin(string Email, string Password)
        {
            HallShopOwner hso = db.HallShopOwners.Where(n => n.email == Email && n.password == Password).SingleOrDefault();
            return hso ;
        }

        public HallShopOwner searchAboutEmail(string email)
        {
            return db.HallShopOwners.Where(n => n.email == email).SingleOrDefault();
        }

        public HallShopOwner searchAboutSSN(string ssn)
        {
            return db.HallShopOwners.Where(n => n.SSN == ssn).SingleOrDefault();
        }

        //---------- Hall And Shop ----------
        public void saveHallOrShop(HallShop hs)
        {
            db.HallShops.Add(hs);
            db.SaveChanges();
        }

        public List<HallShop> getMyHOS(int? id)
        {
            return db.HallShops.Where(n => n.OwnerId == id).ToList();
        } 

        public HallShop getMyHOSById(int? id)
        {
            return db.HallShops.Where(n => n.Id == id).SingleOrDefault();
        }

        public void EditHallOrShop(HallShop hs)
        {
            HallShop hOs = getMyHOSById(hs.Id);
            if(hOs != null)
            {
                hOs.Name    = hs.Name;
                hOs.Street  = hs.Street;
                hOs.City    = hs.City;
                hOs.Station = hs.Station;
                hOs.Type    = hs.Type;
                hOs.Area    = hs.Area;
                hOs.TypeOfShop  = hs.TypeOfShop;
                hOs.description = hs.description;
                db.SaveChanges();

            }
        }

        public void deleteHallOrShop(int id)
        {
            HallShop hs = getMyHOSById(id);
            db.HallShops.Remove(hs);
            db.SaveChanges();
        }

        public List<HallShop> getHallAndShop()
        {
            return db.HallShops.ToList();
        }
        public List<HallShop> getHall()
        {
            return db.HallShops.Where(n => n.Type == "Hall").ToList();
        } 
        public List<HallShop> getShop()
        {
            return db.HallShops.Where(n=>n.Type == "Shop").ToList();
        }


       
    }
}
