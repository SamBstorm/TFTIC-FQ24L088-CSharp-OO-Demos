using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SurchargeOperateur
{
    internal class Vehicle
    {
        public string ConductorName { get; set; }
        public List<string> PassengerNames { get; set; }

        private int _limit;

        public Vehicle(int limit) {
            _limit = limit;
            PassengerNames = new List<string>();
        }

        public void SetConductor(string name)
        {
            ConductorName = name;
        }

        public bool AddPassenger(string name) {
            if (PassengerNames.Count < _limit) {
                PassengerNames.Add(name);
                return true;
            }
            return false;
        }

        public static Vehicle operator +(Vehicle left, Vehicle right)
        {
            Vehicle result = new Vehicle(left._limit + right._limit + 1);
            result.SetConductor(left.ConductorName);

            foreach (string passengerName in left.PassengerNames)
            {
                result.AddPassenger(passengerName);
            }

            result.AddPassenger(right.ConductorName);

            foreach (string passengerName in right.PassengerNames)
            {
                result.AddPassenger(passengerName);
            }

            return result;
        }

        public static Vehicle operator +(Vehicle left, string right)
        {
            if (left.ConductorName is null)
            {
                left.SetConductor(right);
                return left;
            }
            if (!left.AddPassenger(right))
            {
                Console.WriteLine("Plus de place...");
            }
            return left;
        }

        public static bool operator ==(Vehicle left, Vehicle right)
        {
            return left._limit == right._limit;
        }

        public static bool operator !=(Vehicle left, Vehicle right)
        {
            return !(left == right);
        }

        public static bool operator >=(Vehicle left, Vehicle right)
        {
            return left._limit >= right._limit;
        }

        public static bool operator <=(Vehicle left, Vehicle right)
        {
            return left._limit <= right._limit;
        }

        public static bool operator >(Vehicle left, Vehicle right)
        {
            return left._limit > right._limit;
        }

        public static bool operator <(Vehicle left, Vehicle right)
        { 
            return left._limit < right._limit;
        }
        /*
        public override bool Equals(object? obj)
        {
            if (obj is Vehicle vehicle) { return this == vehicle; }
            return base.Equals(obj);
        }*/
    }
}
