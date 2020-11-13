using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accord.MachineLearning;
using Accord.Math.Distances;

/// <summary>
/// A big Credit to http://accord-framework.net/docs/html/T_Accord_MachineLearning_KMeans.htm for Great explaning
/// from ShenkinBag App
/// </summary>

namespace ShenkinStore.Models
{
    public class KmeansAlgo
    {
        ShenkinContext _context = new ShenkinContext();

        public double[] Tolist(Product p)
        {
         
            if (p.productType.Equals(0))
                return new double[] { (double)p.Quantity };
            else if (p.productType.Equals(1))
                return new double[] { (double)p.Quantity };
            else
                return new double[] {  (double)p.Quantity };
        }


        public int[] k_means2()
        {
            Accord.Math.Random.Generator.Seed = 0;
            // A common desire when doing clustering is to attempt to find how to 
            // weight the different components / columns of a dataset, giving them 
            // different importances depending on the end goal of the clustering task.
            // Declare some observations
            List<Product> allproducts = new List<Product>();
            allproducts.AddRange(from pd in _context.Products where pd.Price > 0 select pd);
          
            double[][] observations = new double[allproducts.Count()][];
            for (int i = 0; i < allproducts.Count(); i++)
            {

                observations[i] = new double[10];
                observations[i] = Tolist(allproducts[i]);
           

            }
            // Create a new K-Means algorithm
            KMeans kmeans = new KMeans(k: 3)
            {
                Distance = new WeightedSquareEuclidean(new double[] { 100, 200, 200, 200, 200 })
                //Distance = new WeightedSquareEuclidean(new double[] { 1 })
            };

            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(observations);

            // Use the centroids to parition all the data
            int[] labels = clusters.Decide(observations);
            return labels;
        }



        public List<Product> distans()
        {
            List<Product> show = new List<Product>();
            List<Product> allproducts = new List<Product>();
            allproducts.AddRange((from pd in _context.Products where pd.Price > 0 select pd));
            int[] centers = k_means2();
            Product close1 = new Product();
            close1 = allproducts[0];
            foreach (Product p in allproducts)
            {
                if (chackdis(Tolist(p), centers[0]) > chackdis(Tolist(close1), centers[0]))
                    close1 = p;
            }
            show.Add(close1);
            allproducts.Remove(close1);
            close1 = allproducts[2];
            foreach (Product p in allproducts)
            {
                if (chackdis(Tolist(p), centers[1]) > chackdis(Tolist(close1), centers[1]))
                    close1 = p;
            }
            show.Add(close1);
            allproducts.Remove(close1);
            close1 = allproducts[4];
            foreach (Product p in allproducts)
            {
                if (chackdis(Tolist(p), centers[2]) > chackdis(Tolist(close1), centers[2]))
                    close1 = p;
            }
            show.Add(close1);
            allproducts.Remove(close1);
            //close1 = allproducts[6];
            //foreach (Product p in allproducts)
            //{
            //    if (chackdis(Tolist(p), centers[3]) < chackdis(Tolist(close1), centers[3]))
            //        close1 = p;
            //}
            //show.Add(close1);
            return show;
        }
        public double chackdis(double[] p, int c)
        {
            //double sent = ((p[0] + p[1] + p[2] + p[3] + p[4]) / 5) - c;
            double sent = p[0]  - c;
            return sent;
        }




    }
}
