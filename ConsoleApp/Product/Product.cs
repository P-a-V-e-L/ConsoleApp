using System;

namespace ConsoleApp
{
    public abstract class Product
    {
        private static int _currentId = -1;
        protected decimal _price;
        protected string _name;
        protected ProductType _type;
        protected int _id;
        protected bool _isCalculate;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public ProductType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool IsCalculate
        {
            get { return _isCalculate; }
            set { _isCalculate = value; }
        }

        public static Product CreateProduct(ProductType type, decimal price, string name = "")
        {
            Product p;
            _currentId++;
            switch (type)
            {
                case ProductType.ProductA:
                    p = new ProductA(price, _currentId, name);
                    break;
                case ProductType.ProductB:
                    p = new ProductB(price, _currentId, name);
                    break;
                case ProductType.ProductC:
                    p = new ProductC(price, _currentId, name);
                    break;
                case ProductType.ProductD:
                    p = new ProductD(price, _currentId, name);
                    break;
                case ProductType.ProductE:
                    p = new ProductE(price, _currentId, name);
                    break;
                case ProductType.ProductF:
                    p = new ProductF(price, _currentId, name);
                    break;
                case ProductType.ProductG:
                    p = new ProductG(price, _currentId, name);
                    break;
                case ProductType.ProductH:
                    p = new ProductH(price, _currentId, name);
                    break;
                case ProductType.ProductI:
                    p = new ProductI(price, _currentId, name);
                    break;
                case ProductType.ProductJ:
                    p = new ProductJ(price, _currentId, name);
                    break;
                case ProductType.ProductK:
                    p = new ProductK(price, _currentId, name);
                    break;
                case ProductType.ProductL:
                    p = new ProductL(price, _currentId, name);
                    break;
                case ProductType.ProductM:
                    p = new ProductM(price, _currentId, name);
                    break;
                default:
                    throw new Exception("Error create Product");
            }
            return p;
        }

    }
}
