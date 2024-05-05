﻿using System.Windows;
using System.Collections.Generic;
using System;
using System.Windows.Interop;
using Xceed;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Drawing;

namespace TaskGenerator
{
    public partial class MainWindow : Window
    {
        public class Students : List<string>
        {
            public Students(string path) : base(Import.ImportStudents(path))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    Console.WriteLine(this[i]);
                }
            }

            public Students()
            {
                //Console.WriteLine("Students()");
            }
        }

        public Students students = new Students();

        public int selectedVariant = 0;

        public List<Variant> variantList = new List<Variant>{};

        public MainWindow()
        {
            InitializeComponent();

            generator.generateBtn.Click += onClick;
            variants.variantChange += changeVariant;
            tasks.parentWindow = this;
        }

        public void onClick(object sender, RoutedEventArgs e) {
            var count = 0;
            var tasksList = new List<int>(); 
            try {
                count = Convert.ToInt32(generator.countField.Text);
                tasksList = Import.GetTaskTypesFromString(generator.tasksField.Text);
                if (tasksList.FindAll(x => x <= 0 || x > 21).Count != 0) throw new FormatException();
            }
            catch {
                MessageBox.Show("Введены некорректные данные", "Ошибка");
                return;
            }
            selectedVariant = 0;
            variantList = Variant.GenerateSomeVariants(count, tasksList);
            
            if(students.Count > 0)
            {
                for(int i = 0; i < variantList.Count; i++)
                    variantList[i].student = "\n" + students[i];
            }
            variants.presentVariants(variantList);
            tasks.setVariant(variantList[0], 0);
            
        }

        public void changeVariant(int v) {
            selectedVariant = v;
 
            tasks.setVariant(variantList[v], v);
        }

        public void updateTask(int index) {
            variantList[selectedVariant].tasks[index].RegenerateTaskValues();
            tasks.updateCard(index);
		}

        public void updateTaskSubtype(int index)
        {
            variantList[selectedVariant].tasks[index].RegenerateTaskSubtype();
            tasks.updateCard(index);
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var win = new AboutWindow();
            win.Show();

        }

        
    }

}
