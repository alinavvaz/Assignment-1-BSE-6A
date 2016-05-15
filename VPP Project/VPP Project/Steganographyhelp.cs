using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VPP_Project
{
    class Steganographyhelp
    {
        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };
        public static Bitmap encode(string text, Bitmap img)
        {
            State state = State.Hiding;
            int characterIndex = 0; //holds the index of the character currently being hidden.
            int characterValue = 0; // Holds the value of the character that is converted to integer.
            long pixelElementIndex = 0;//holds the pixel of the color element (R,G,B pixel)
            int zeros = 0;//will hold the trailing zeros that will be assigned when the process is finished.

            int R = 0;             //Will hold the pixel elements on which processing will be done.
            int G = 0;
            int B = 0;


            //For loop to pass through the rows and columns of the image.
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {



                    Color pixel = img.GetPixel(j, i);//Will hold the pixel under processing


                    //Clearing the least significant bit (LSB) from each element(R,G,B)

                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;


                    //For each pixel passing through the R,G,B elements.
                    for (int n = 0; n < 3; n++)
                    {

                        //To check if new 8 bits have been processed.
                        if (pixelElementIndex % 8 == 0)
                        {
                            //To check if process has finished, It would be finished when 8 zeros are added.
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {

                                //Apply last pixel on the image, even only part of it has been affected.
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    img.SetPixel(j, i, Color.FromArgb(R, G, B)); //SETTING DATA ON IMAGE'S RGB VALUE.
                                }
                                //Returns the picture with hidden text which is set previously in the upper statement.
                                return img;

                            }

                            //To check if all the characters have been hidden in the image.
                            if (characterIndex >= text.Length)
                            {

                                //Add zeros to mark end of text, zeros are added till there are total 8.
                                state = State.Filling_With_Zeros;
                            }

                            else

                            {

                                //Move to the next character and start the above process again.
                                characterValue = text[characterIndex++];
                            }

                        }


                        //Checks which picture element R,G,B has the turn to hide the bit in it's least significant bit.
                        switch (pixelElementIndex % 3)

                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        //The right most bit in the character will be (charValue%2). To put this value instead of the LSB
                                        //of the pixel element just add it to it.
                                        //Remember that we cleared the LSB of the pixel element
                                        //before this operation being performed.
                                        R += characterValue % 2;

                                        //Removes the added bit of the character so that we can reach the next one next time.
                                        //by dividing characterValue by 2 and assigning the result in characterValue.
                                        characterValue /= 2;
                                    }
                                }
                                break;

                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += characterValue % 2;


                                        characterValue /= 2;
                                    }
                                }
                                break;

                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += characterValue % 2;

                                        characterValue /= 2;
                                    }

                                    img.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;


                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {

                            //Increases the zeros till they are total of 8 in the bit.
                            zeros++;
                        }
                    }
                }
            }
            //Will return the image that has the hidden text in it saved now.
            return img;

        }






    //Extraction Function for getting the data out from the encoded selected picture.

        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int characterValue = 0;

            //Will hold the data that is extracted out from the image and show as the extracted text.
            string extractedText = string.Empty;


            for (int i = 0; i < bmp.Height; i++)
            {


                //For passing through the rows and columns of the picture that has been chosen by us.

                for (int j = 0; j < bmp.Width; j++)
                {


                    Color pixel = bmp.GetPixel(j, i);

                    //To pass through the R, G, B values through this loop

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {

                                    //LSB will be taken by pixel.R%2. Now we add one bit to the righmost side of the character by replacing
                                    //the added bit with the LSB of the pixel by adding characterValue = characterValue*2 to pixel.R,G,B.
                                    characterValue = characterValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    characterValue = characterValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    characterValue = characterValue * 2 + pixel.B % 2;
                                }
                                break;


                        }

                        colorUnitIndex++;


                        //If 8 bits have been added then add the current one to the result text.

                        if (colorUnitIndex % 8 == 0)
                        {
                            //Reversing the values since the process happened on the right each time.

                            characterValue = reverseBits(characterValue);

                            // can be zero if it is the last character of the 8 zeros added.

                            if (characterValue == 0)
                            {
                                return extractedText;
                            }

                            // convert the character value from int to char
                            char c = (char)characterValue;

                            // add the current character to the result text
                            extractedText += c.ToString();
                        }
                    }
                }
            }


            return extractedText;



        }


        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;

        }

    }
}
