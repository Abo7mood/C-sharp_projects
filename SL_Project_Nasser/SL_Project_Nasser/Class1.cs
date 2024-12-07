

using System;
using System.Collections.Generic;


namespace SL_Project_Nasser
{

    public class QuestionsData
    {
        public int Chapter { get; set; }
        public int Session { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string Answers { get; set; }
        public int Answer { get; set; }
        public string AnswerName { get; set; }
    }
    public class Questions
    {


        public Dictionary<int, QuestionsData> questions = new Dictionary<int, QuestionsData>()
        {
            { 0, new QuestionsData {
                Chapter=1,
                Session=1,
                Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="………. is an electronic device that is programmed to take input,\n" +
                " process that input based oninstructions, and give the user the output."

                ,Answers="1: System Unit \n 2: Computer \n 3: Supercomputer \n 4: System Software",

                AnswerName="Computer",
            Answer=2
            }

            },

           { 1, new QuestionsData {
               Chapter=1,
                Session=1,
                Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="A ……… is extremely fast and expensive computer that can execute millions of instructions in less time."

                ,Answers="Supercomputer – System – Computer - System Unit",
                 AnswerName="Supercomputer",
            Answer=1} },


          { 2, new QuestionsData {
              Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="The Motherboard, Central Processing Unit (CPU), and Memory Unit are just a few of the electrical components that are stored in the ……"

                ,Answers="System Unit – System – Supercomputer – Computer",
              AnswerName="System Unit",
            Answer=1}
          },

                { 3, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="…….. is in between the computer hardware and the application software. Users do not interact \n"+
                "directly with it as it runs in the background",

                 AnswerName="System",
                Answers="Supercomputer – System – Computer - System Unit",
                Answer=2,
                }

           },
               { 4, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="………… is also known as the heart of the computer.",
                 AnswerName="Motherboard",
                Answers="CPU  – Motherboard – Mouse - Screen",
                Answer=2,
                }

           },
                { 5, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="……… is named as the brain of the computer.",
                 AnswerName="CPU",
                Answers="CPU  – Motherboard – Mouse - Screen",
                Answer=1,
                }

           },
                 { 6, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="………….. executes all the arithmetic and logical operations such as basic addition,\n" +
                     " subtraction, multiplication, division and comparisons (+, -, *, /, <, >, = =).",

                 AnswerName="ALU",
                Answers="CD – CU – ALU - DVD",
                Answer=3,
                }

           },
                  { 7, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="………. is like an execution unit which controls the rest of the computer instructions and coordinates with other devices in the queues.",
                 AnswerName="CU",
                Answers="CD – CU – ALU - DVD",
                Answer=2,
                }

           },
                   { 8, new QuestionsData {
               Chapter=1,
                Session=1,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Permanent data and information storage is accomplished through storage",
                 AnswerName="Secondary",
                Answers="Primary – Secondary – Input - Output",
                Answer=2,
                   }

           },
                   { 9, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_______allows you to\n "+
"create documents, save them digitally, show them on screens, edit\n"+
"them by typing instructions and characters, and print them out on papers.",

                 AnswerName="Word processor",
                Answers="Word processor - Export Document - Tabs - Templates",
                Answer=1,
                   }

           },



           { 10, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="______ includes a set of commands located below different tabs, which is divided into groups\n "+
"having logically related commands.",

                 AnswerName="Ribbon",
                Answers="Work Area - Rulers - Ribbon - Groups",
                Answer=3,
                   }

           },



           { 11, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="The ______ is the blinking vertical line in the Work Area.",

                 AnswerName="Insertion Point",
                Answers="Referencing - Status Bar - Insertion Point - View Buttons",
                Answer=3,
                   }

           },




           { 12, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_______ allows you to do the things quickly and efficiently,\n"+
                 "keeping you free from remembering and locating the commands in various tabs & ribbons.",

                 AnswerName="Tell me box",
                Answers="Tell me box - zoom Slider and Buttons - Navigating with Keyboard",
                Answer=1,
                   }

           },


           { 13, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Using the ______, you may obtain definitions, Wikipedia pages and related searches.",

                 AnswerName="Smart Lookup",
                Answers="Smart Lookup - Processing Tools - Design and Layout - Spelling Checker",
                Answer=1,
                   }

           },


           { 14, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Create a New Document",

                 AnswerName="CTRL+N",
                Answers="CTRL+N - CTRL+R - CTRL+M - CTRL+K",
                Answer=1,
                   }

           },



           { 15, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Save a Document",

                 AnswerName="CTRL+S",
                Answers="CTRL+D - CTRL+S - CTRL+G - CTRL+L",
                Answer=2,
                   }

           },




           { 16, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Open a Document",

                 AnswerName="CTRL+O",
                Answers="CTRL+O - CTRL+I - CTRL+Q - CTRL+T",
                Answer=1,
                   }

           },




           { 17, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Close a Document",

                 AnswerName="CTRL+W",
                Answers="CTRL+U - CTRL+A - CTRL+W - CTRL+E",
                Answer=3,
                   }

           },



           { 18, new QuestionsData {
               Chapter=1,
                Session=2,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="Print a Document",

                 AnswerName="CTRL+P",
                Answers="CTRL+P - CTRL+R - CTRL+Y - CTRL+H",
                Answer=3,
                   }

           },


           { 19, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_____ commands allow you to adjust and enhance the appearance of your text,\n"+
                 "such as font,fontsize,bold,italic,underlining etc.",

                 AnswerName="Font Group",
                Answers="Texbox - Font Group - Smart Art - picture",
                Answer=2,
                   }

           },



           { 20, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="______ enables you to copy objects from a document and paste them anywhere in the same document or in another another document.",

                 AnswerName="Clipboard",
                Answers="Clipboard - Online Picture - Styles",
                Answer=1,
                   }

           },



           { 21, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="____ Command is used to copy the formatting applied to a section of text to another section of text.",

                 AnswerName="Format Painter",
                Answers="Format Painter - Font Color - text color - Inserting Table",
                Answer=1,
                   }

           },


           { 22, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="The______ command is used to end the current page at the cursor position and move the cursor to the next page.",

                 AnswerName="Page Break",
                Answers="Cover Page - Blank Page - Page Break - Cells",
                Answer=1,
                   }

           },


           { 23, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="The Format Painter command is used to copy the formatting applied to a section of text to another section of text.",

                 AnswerName="True",
                Answers="True - False",
                Answer=1,
                   }

           },


           { 24, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="MS Word 2016, after inserting a table, you cannot insert additional rows or columns in the table.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },

           { 25, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="Combining two or more cells together into one cell is called splitting cells.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },


           { 26, new QuestionsData {
               Chapter=1,
                Session=3,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="Merging cells combining only two together in one cell is called merging cells.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },


           { 27, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="______ is a set of formatting choices that include a set of theme colors, a set of theme fonts (including heading and body text fonts),\n"+
                 "and a set of theme effects (including lines and all effects).",

                 AnswerName="Document Theme",
                Answers="Document Theme - Draft - Read Mode - Web Layout",
                Answer=1,
                   }

           },


           { 28, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_______command enables you to add see-through text, such as “Confidential” or “Urgent” behind the content on the page.",

                 AnswerName="Watermark",
                Answers="Page Orientation - Watermark - Add Columns - Page Border",
                Answer=2,
                   }

           },


           { 29, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_________are the blank areas of space around the edge of your document.",

                 AnswerName="Margins",
                Answers="Page color - Theme Fonts - Margins - Ruler",
                Answer=3,
                   }

           },


           { 30, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="  ______ tab allows you to customize the way your document’s page is set up. It helps you to change\n"+ "orientation, page size, margins, indentation, line spacing, etc.",


                 AnswerName="Print Layout",
                Answers="Print Layout - Page Width - Gridlines - Hyphenation",
                Answer=1,
                   }

           },


           { 31, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="______View allows you to create an outline of a document and shows the content as a bulleted list.\n"+ "In the Outline view, a contextual tab Outlining appears with various outline tools.",


                 AnswerName="Outline",
                Answers="Clipboard - Font Group - Page Break - Outline",
                Answer=4,
                   }

           },


           { 32, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="Document formatting contains the predefined document formats, which can help to enhance the appearance of the whole document.",

                 AnswerName="True",
                Answers="True - False",
                Answer=1,
                   }

           },


           { 33, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="A document theme is a set of formatting choices that include a page margin, orientation and page size.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },


           { 34, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="You cannot remove a watermark text from a document.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },



           { 35, new QuestionsData {
               Chapter=1,
                Session=4,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="The outline view is the default view when you create a new document.\n" + "This view is often used to work with standard documents, such as letters, brochures, reports, etc.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },



           { 36, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="A ________ displays the topics of the entire document in a list format and facilitates easy location of topics.",

                 AnswerName="Margins",
                Answers="Page color - Theme Fonts - Margins - Ruler",
                Answer=3,
                   }

           },



           { 37, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_______ enables you to quickly jump to the marked locations within the document instead of scrolling through many pages of your document.",

                 AnswerName="Bookmark",
                Answers="Bookmark - Spelling and Grammar - Simple Markup - Footnotes",
                Answer=1,
                   }

           },


            { 38, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="create a linked text in your document for accessing a web, page, marked places in the document (headings, bookmarks) .",

                 AnswerName="Hyperlinking",
                Answers="Endnotes - Comments - Hyperlinking - Compare Documents",
                Answer=3,
                   }

           },



            { 39, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="complete the sentences , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2 , Enter Number 3 : for answer 3 , Enter Number 4 : for answer 4",

                Question="_________ is reviewing your work attentively to identify and correct problems, as well as recommending alternative wording for improved readability.",

                 AnswerName="Proofreading",
                Answers="Proofreading - Revisions - Thesaurus - Show Notes",
                Answer=1,
                   }

           },



            { 40, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="The Footnote or Endnote Command helps you to insert additional notes about True and False words/phrases either at the end of each page or at the end of the document.",

                 AnswerName="True",
                Answers="True - False",
                Answer=1,
                   }

           },


            { 41, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="The Links group consists of commands that enable you to create table of content, footnotes and endnotes.",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },


            { 42, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="Bookmark is a process to create a link in your document for quick access to webpages and files .",

                 AnswerName="False",
                Answers="True - False",
                Answer=2,
                   }

           },


            { 43, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="Red Wavy Underline is flagged to show the spelling errors.",

                 AnswerName="True",
                Answers="True - False",
                Answer=1,
                   }

           },


            { 44, new QuestionsData {
               Chapter=1,
                Session=5,
                 Type="True or False , \n \n" +
                "Enter Number 1 : for answer 1 , Enter Number 2 : for answer 2",

                Question="The Draft view is designed to edit and format text quickly.",

                 AnswerName="True",
                Answers="True - False",
                Answer=1,
                   }

           },



        };
    }
}


