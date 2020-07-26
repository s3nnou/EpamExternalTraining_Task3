using Figures;
using MaterialsLibrary;
using System;
using System.Collections.Generic;

namespace CollectionLibrary
{
    /// <summary>
    /// Girl's box. Collection of a figures. 
    /// </summary>
    public class Box
    {
        private Figure[] content = new Figure[20];
        private int _size;

        public Figure this[int index]
        {
            get
            {
                return content[index];
            }
            set
            {
                content[index] = value;
            }
        }

        public Figure[] Items => content;

        /// <summary>
        /// Returns actual quantity of a figures
        /// </summary>
        public int Size
        {
            get
            {
                _size = 0;
                for (int i = 0; i < content.Length; i++)
                {
                    if(content[i] != null)
                    {
                        _size++;
                    }
                }

                return _size;
            }
            set
            {
                _size = value;
            }
        }

        /// <summary>
        /// Adds new Figure to the Box
        /// </summary>
        /// <param name="figure"></param>
        public void Add(Figure figure)
        {
            int index = 0;

            if(Size == 20)
            {
                throw new Exception("Box is full");
            }
            else
            {
                for (int i = 0; i < content.Length; i++)
                {
                    if(content[i] == null)
                    {
                        index = i;
                        break;
                    }

                    if (this[i].Equals(figure))
                    {
                        throw new Exception("Only uniqe fugires can be put in the box");
                    }
                }

                content[index] = figure;

            }
        }

        /// <summary>
        /// Shows any figure form the box.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Taken Figure</returns>
        public Figure Show(int index)
        {
            if(content[index] != null)
            {
                return content[index];
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Takes any figure from the box and removes it form the collection completely.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>taken figure</returns>
        public Figure Take(int index)
        {
            
            if (content[index] != null)
            {
                Figure takenFigure;

                if(index == Size - 1)
                {
                    takenFigure = content[Size - 1];
                    content[Size - 1] = null;
                    Size--;
                }
                else
                {
                    takenFigure = content[index];

                    for (int i = index; i < Size; i++)
                    {
                        content[i] = content[i + 1];
                    }
                }

                return takenFigure;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Replaces any figure with another by its index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="figure"></param>
        public void Set(int index, Figure figure)
        {
            if (index > 20 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                content[index] = figure;
            }
        }

        /// <summary>
        /// Finds equal figure
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>true - if there are equal figure, else - if not</returns>
        public bool Find(Figure figure)
        {
            for (int i = 0; i < Size; i++)
            {
                if (content[i].Equals(figure))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Calculates total area.
        /// </summary>
        /// <returns>Area</returns>
        public double GetTotalArea()
        {
            if (Size == 0)
            {
                return 0;
            }
            else
            {
                double area = 0;

                for(int i = 0; i < Size; i++)
                {
                    area += content[i].Area;
                }

                return area;
            }
        }

        /// <summary>
        /// Calculates total perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public double GetTotalPerimeter()
        {
            if (Size == 0)
            {
                return 0;
            }
            else
            {
                double area = 0;

                for (int i = 0; i < Size; i++)
                {
                    area += content[i].Perimeter;
                }

                return area;
            }
        }

        /// <summary>
        /// Returns all circles from the collection
        /// </summary>
        /// <returns>All cricles - if they exsist, if not - null</returns>
        public List<Figure> GetCircles()
        {
            List<Figure> takenFigures = new List<Figure>();

            if (Size == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < Size; i++)
                {
                    if (content[i] is Circle)
                    {
                        takenFigures.Add(content[i]);
                    }
                }

                return takenFigures;
            }
        }

        /// <summary>
        /// Returns all film figures from the collection
        /// </summary>
        /// <returns>All film figures - if they exsist, if not - null</returns>
        public List<Figure> GetFilmFigures()
        {
            List<Figure> takenFigures = new List<Figure>();

            if (Size == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < Size; i++)
                {
                    if (content[i] is IFilm)
                    {
                        takenFigures.Add(content[i]);
                    }
                }

                return takenFigures;
            }
        }

        /// <summary>
        /// Displays an information about a Box 
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            string str  = "What in the box:";

            foreach (var item in Items)
            {
                if(item != null)
                {
                    str += item.ToString() + "\n";

                }
                else
                {
                    str += "Valid slot" + "\n";
                }
            }

            return str;
        }

        /// <summary>
        /// Find equal Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true - if all array members were equal, if not - false</returns>
        public override bool Equals(object obj)
        {

            if (obj is Box)
            {
                Box box = obj as Box;

                for (var i = 0; i < Size; i++)
                {
                    if (!Items[i].Equals(box.Items[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns hashcode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            int sum = 0;
            foreach(var item in Items)
            {
                sum += item.GetHashCode();
            }

            return (content.GetHashCode() ^ sum ^  Size.GetHashCode());
        }
    }
}
