﻿using HotelProject.BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BL.Model
{
    public class Address
    {
        public Address(string municipality, string zipCode, string houseNumber, string street)
        {
            Municipality = municipality;
            ZipCode = zipCode;
            HouseNumber = houseNumber;
            Street = street;
        }

        public Address(string addressLine)
        {
            string[] parts = addressLine.Split(new char[] { '|' });
            HouseNumber = parts[3];
            Street = parts[1];
            Municipality = parts[0];
            ZipCode = parts[2];
        }

        private string _municipality;
        public string Municipality 
        { 
            get 
            { 
                return _municipality; 
            } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AddressException("Municipality is invalid!");
                }
                else
                {
                    _municipality = value;
                }
            }
        }

        private string _zipCode;
        public string ZipCode
        { 
            get
            {
                return _zipCode;
            } 
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AddressException("ZipCode is invalid!");
                }
                else
                {
                    _zipCode = value;
                }
            }
        }

        private string _houseNumber;
        public string HouseNumber 
        { 
            get 
            {
                return _houseNumber;
            }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AddressException("HouseNumber is invalid!");
                }
                else
                {
                    _houseNumber = value;
                }
            }
        }

        private string _street;
        public string Street
        { 
            get
            {
                return _street;
            } 
            set
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AddressException("Street is empty!");
                }
                else
                {
                    _street = value;
                }
            }
        }

        public override string ToString()
        {
            return $"({Municipality} [{ZipCode}] - {Street} - {HouseNumber})";
        }

        public string ToAddressLine()
        {
            return $"{Municipality}|{ZipCode}|{Street}|{HouseNumber}";
        }
    }
}