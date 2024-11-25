using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default

        DBForTestEntities _context = new DBForTestEntities();
        public IEnumerable<Branch> Get()
        {
            return _context.Branches.ToList();
        }

        // GET: api/Default/5
        public Branch Get(int id)
        {
            return _context.Branches.Where(p => p.BranchId == id).FirstOrDefault();
        }

        // POST: api/Default
        public bool Post(Branch branchItem)
        {
            bool status;
            try
            {
                _context.Branches.Add(branchItem);
                _context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        // PUT: api/Default/5
        public bool Put(Branch branchItem)
        {
            bool status;
            try
            {
                Branch branchData = _context.Branches.Where(p => p.BranchId == branchItem.BranchId).FirstOrDefault();
                if (branchData != null)
                {
                    branchData.BranchName = branchItem.BranchName;
                    _context.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        // DELETE: api/Default/5
        public bool Delete(int id)
        {
            bool status;
            try
            {
                Branch prodItem = _context.Branches.Where(p => p.BranchId == id).FirstOrDefault();
                if (prodItem != null)
                {
                    _context.Branches.Remove(prodItem);
                    _context.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
