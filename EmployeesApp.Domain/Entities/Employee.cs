﻿using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Domain.Entities;

public class Employee
{

    public int Id { get; set; }

    
    public string Name { get; set; } = string.Empty;



   
    public string Email { get; set; } = string.Empty;




    

}
