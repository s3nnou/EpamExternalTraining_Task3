using epam_task_3._1;
using MaterialsLibrary;
using System;
using System.Collections.Generic;

namespace CollectionLibrary
{
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

        public void Add(Figure figure)
        {
            if(Size == 20)
            {
                throw new Exception("Box is full");
            }
            else
            {
                for (int i = 0; i < content.Length; i++)
                {
                    if (this[i].Equals(figure))
                    {
                        throw new Exception("Only uniqe fugires can be put in the box");
                    }
                }

                content[Size - 1] = figure;
            }
        }

        public Figure Show(int index)
        {
            if(content[index] != null)
            {
                return content[index];
            }
            else
            {
                throw new Exception("There are no any figure with this index");
            }
        }

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
                throw new Exception("There are no any figure with this index");
            }
        }

        public void Set(int index, Figure figure)
        {
            if (index > 20)
            {
                throw new Exception("Out of bounce");
            }
            else
            {
                content[index] = figure;
            }
        }

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

        public override int GetHashCode()
        {
            return (content.GetHashCode() ^ Size.GetHashCode());
        }
    }
}
