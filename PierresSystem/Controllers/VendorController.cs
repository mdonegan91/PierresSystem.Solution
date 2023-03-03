using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresSystem.Models;

namespace PierresSystem.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/songs")]
    public ActionResult Create(int vendorId, string orderName)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order (orderName, foundVendor.Name);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("vendor", foundVendor);
      model.Add("order", vendorOrders);
      return View("Show", model);
    }
    }
  }