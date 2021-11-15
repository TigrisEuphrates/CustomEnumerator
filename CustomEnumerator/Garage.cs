using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage: CIEnumerable
    {
        private Car[] carArray = new Car[4];
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return carArray.GetEnumerator();
        //}
        CIEnumerator CIEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public carEnum GetEnumerator()
        {
            return new carEnum(carArray);
        }
    }
    class carEnum : CIEnumerator
    {
        public Car[] _car;
        int position = -1;
        public carEnum(Car[] list)
        {
            _car = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _car.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        object CIEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Car Current
        {
            get
            {
                try
                {
                    return _car[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
