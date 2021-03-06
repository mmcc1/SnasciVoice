﻿/* This code is also available with a commercial license.  Please refer to Snasci.com for further information. */

/*
 * Snasci Voice - 3D acoustically modelled voicebox for voice synthesis
 * Copyright (C) 2016 Snasci
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * vocalis (muscle)
 * 
 * Definitions:
 * 1. intrinsic muscle of the larynx formed by several of the finer and most medial fibers of the thyroaryteroid muscle attached directly to the outer side of the vocal ligament; origin, 
 * depression between the two laminae of thyroid cartilage; insertion, portions of vocal ligament and vocal process of arytenoid; action, shortens and relaxes portions of vocal cords; 
 * nerve supply, recurrent laryngeal.
*/
//Reference: https://www.youtube.com/watch?v=b89RSYCaUBo
//for exhalation, loosen cords, lower pitch
//Model as a dynamic process of 3D acoustical activity linked to lung activity
//Output is a pcm - loosen cords, lower pitch
namespace SnasciVoiceBox.Intrinsic
{
    class Vocalis
    {
    }
}
