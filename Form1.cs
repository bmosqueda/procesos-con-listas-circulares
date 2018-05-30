using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_First_In_First_Off__FIFO_
{
    public partial class Form1 : Form
    {
        public class Process
        {
            public int NecessaryCycles { get; set; }
            public Process Next { get; set; }
            private int processNumber;
            public int ProcessNumber { get { return processNumber; } }


            public Process(int necessaryCycles, int processNumber)
            {
                this.NecessaryCycles = necessaryCycles;
                this.processNumber = processNumber;
            }

            public override string ToString()
            {
                return "\n****Proceso: " + processNumber + " ****\nNecessaryCycles: " + NecessaryCycles + "\n";
            }
        }

        public class Queue
        {
            public int numberProcesses;
            public int NumberProcesses { get { return numberProcesses; } }

            private int necessaryCycles;
            public int NecessaryCycles { get { return necessaryCycles; } }

            private Process first;
            private Process last;

            //Add in the last position FIFO
            public void add(Process newProcess)
            {
                if (first != null)
                {
                    last.Next = newProcess;
                    last = newProcess;
                    numberProcesses++;
                    necessaryCycles += newProcess.NecessaryCycles;
                }
                else
                {
                    first = newProcess;
                    last = newProcess;
                    numberProcesses = 1;
                    necessaryCycles = newProcess.NecessaryCycles;
                }
            }

            public Process poll()
            {
                if (first != null)
                {
                    if (numberProcesses > 1)
                    {
                        Process temp = first;
                        first = first.Next;
                        numberProcesses--;
                        necessaryCycles -= temp.NecessaryCycles;
                        return temp;
                    }
                    else
                    {
                        Process temp = first;
                        first = null;
                        last = null;
                        numberProcesses = 0;
                        necessaryCycles = 0;
                        return temp;
                    }
                }
                return null;
            }

            public Process peek()
            {
                if (first != null)
                    return first;
                return null;
            }

            public string list()
            {
                if (first != null)
                {
                    string processString = first.ToString();
                    Process temp = first;
                    for (int i = 2; i <= numberProcesses; i++)
                    {
                        temp = temp.Next;
                        processString += temp.ToString();
                    }
                    return processString;
                }
                else
                    return "No se ha agregado ningún proceso a la cola";
            }
        }

        public class Processor
        {
            public Queue queue;
            private Process[] cores;
            private int completedProcesses;
            public int CompletedProcesses { get { return completedProcesses; } }
            public Processor(int coresNumber)
            {
                if (coresNumber < 1)
                    coresNumber = 1;
                cores = new Process[coresNumber];
                queue = new Queue();
            }

            //this function will be called each cycle for dicreasing by one each necessaryCycles of process in the cores
            public void work()
            {
                for(int i = 0; i < cores.Length; i++)
                {
                    if (cores[i] != null)
                    {
                        if (cores[i].NecessaryCycles != 0)
                        {
                            cores[i].NecessaryCycles--;
                            if(cores[i].NecessaryCycles == 0)
                            {
                                cores[i] = queue.poll();
                                completedProcesses++;
                            }
                        }
                        else
                        {
                            cores[i] = queue.poll();
                            completedProcesses++;
                        }
                    }
                }
            }

            public string listCores()
            {
                string coresString = "";
                for(int i = 0; i < cores.Length; i++)
                {
                    if (cores[i] != null)
                        coresString += "\n----Core index: " + i + "-----" + cores[i].ToString();
                    else
                        coresString += "\n-----NULL index: " + i + "-----\n";
                }
                return coresString;
            }

            public void addProcess(Process newProcess)
            {
                queue.add(newProcess);
            }

            public void repartProcess()
            {
                for(int i = 0; i < cores.Length; i++)
                {
                    if (cores[i] == null)
                        cores[i] = queue.poll();
                }
            }

            public int getProcessPending()
            {
                int pending = queue.numberProcesses;
                for (int i = 0; i < cores.Length; i++)
                    if (cores[i] != null)
                        if (cores[i].NecessaryCycles > 0)
                            pending++;
                return pending;
            }

            public int getCyclesPending()
            {
                int pending = queue.NecessaryCycles;
                for (int i = 0; i < cores.Length; i++)
                    if (cores[i] != null)
                        if (cores[i].NecessaryCycles > 0)
                            pending += cores[i].NecessaryCycles;
                return pending;
            }
        }

        Processor processor;
        Random random;
        int cycles = 0;
        int cyclesQueueEmpty = 0;
        int limit = 0;

        public Form1()
        {
            InitializeComponent();
            processor = new Processor(3);
            random = new Random();
        }

        //35% of probability of generating a new Process between 4 and 14 necessaryCycles to be completed
        public Process generateNewProcess(int processNumber)
        {
            int isGenerate = random.Next(101);
            if (isGenerate <= 55)
                return new Process(random.Next(4, 15), processNumber);
            return null;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            processor = new Processor(Convert.ToInt32(numCores.Value));
            cycles = 0;
            cyclesQueueEmpty = 0;
            limit = Convert.ToInt32(numCycles.Value);
            lblPendingCycles.Visible = false;
            lblPendingProcess.Visible = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cycles == limit)
            {
                ((Timer)sender).Stop();
                MessageBox.Show("Terminado");
                processor.repartProcess();
                txtQueu.Text = processor.queue.list();
                txtCores.Text = processor.listCores();

                lblQueueEmpty.Text = "Ciclos cola vacía: " + cyclesQueueEmpty;
                lblProcessesComplete.Text = "Procesos completados: " + processor.CompletedProcesses;
                lblPendingCycles.Visible = true;
                lblPendingProcess.Visible = true;
                lblPendingProcess.Text = "Procesos pendientes: " + processor.getProcessPending();
                lblPendingCycles.Text = "Ciclos pendientes: " + processor.getCyclesPending();
                cycles = 0;
                cyclesQueueEmpty = 0;
            }
            else
            {
                cycles++;
                Process temp = generateNewProcess(cycles);
                if (temp != null)
                    processor.addProcess(temp);
                if (processor.queue.peek() == null)
                    cyclesQueueEmpty++;
                processor.repartProcess();
                processor.work();
                txtQueu.Text = processor.queue.list();
                txtCores.Text = processor.listCores();

                lblCycles.Text = "Ciclos: " + cycles;
                lblQueueEmpty.Text = "Ciclos cola vacía: " + cyclesQueueEmpty;
                lblProcessesComplete.Text = "Procesos completados: " + processor.CompletedProcesses;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!timer.Enabled)
                timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
        }

        //Simulation og 300 cycles
        private void btnSimulation_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            processor = new Processor(Convert.ToInt32(numCores.Value));
            lblPendingCycles.Visible = false;
            lblPendingProcess.Visible = false;
            for (int i = 0; i < 300; i++)
            {
                cycles++;
                Process temp = generateNewProcess(cycles);
                if (temp != null)
                    processor.addProcess(temp);
                if (processor.queue.peek() == null)
                    cyclesQueueEmpty++;
                processor.repartProcess();
                processor.work();
                txtQueu.Text = processor.queue.list();
                txtCores.Text = processor.listCores();

                lblCycles.Text = "Ciclos: " + cycles;
                lblQueueEmpty.Text = "Ciclos cola vacía: " + cyclesQueueEmpty;
                lblProcessesComplete.Text = "Procesos completados: " + processor.CompletedProcesses;
            }
            processor.repartProcess();
            txtQueu.Text = processor.queue.list();
            txtCores.Text = processor.listCores();

            lblQueueEmpty.Text = "Ciclos cola vacía: " + cyclesQueueEmpty;
            lblProcessesComplete.Text = "Procesos completados: " + processor.CompletedProcesses;
            lblPendingCycles.Visible = true;
            lblPendingProcess.Visible = true;
            lblPendingProcess.Text = "Procesos pendientes: " + processor.getProcessPending();
            lblPendingCycles.Text = "Ciclos pendientes: " + processor.getCyclesPending();
            cycles = 0;
            cyclesQueueEmpty = 0;
        }
    }
}
