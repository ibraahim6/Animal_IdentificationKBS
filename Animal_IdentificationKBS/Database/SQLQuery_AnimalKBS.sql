CREATE TABLE Animal_KBS(
   id                 INTEGER  NOT NULL PRIMARY KEY 
  ,animal_name              VARCHAR(50) NOT NULL
  ,animal_photo              VARCHAR(250) NOT NULL
  ,Q1              VARCHAR(10) NOT NULL DEFAULT 'no'  --1-Have backbone?
  ,Q2              VARCHAR(10) NOT NULL DEFAULT 'no' --2-Warm blooded?
  ,Q3              VARCHAR(10) NOT NULL DEFAULT 'no'--3-Always in water ?
  ,Q4              VARCHAR(10) NOT NULL DEFAULT 'no'--4-Scalled skin ?
  ,Q5              VARCHAR(10) NOT NULL DEFAULT 'no'--5-Jump ?
  ,Q6              VARCHAR(10) NOT NULL DEFAULT 'no'--6-Rounded shell ?
  ,Q7              VARCHAR(10) NOT NULL DEFAULT 'no'--7-Have limbs ?
  ,Q8              VARCHAR(10) NOT NULL DEFAULT 'no'--8-Have a boney skeleton ?
  ,Q9              VARCHAR(10) NOT NULL DEFAULT 'no'--9-Drinks milk?
  ,Q10              VARCHAR(10) NOT NULL DEFAULT 'no'--10-Eat red meat ?
  ,Q11              VARCHAR(10) NOT NULL DEFAULT 'no'--11-Have hooves ?
  ,Q12              VARCHAR(10) NOT NULL DEFAULT 'no'--12-Live in water?
  ,Q13              VARCHAR(10) NOT NULL DEFAULT 'no'--13-Have large front teeth ?
  ,Q14              VARCHAR(10) NOT NULL DEFAULT 'no'--14-Have a pouch?
  ,Q15              VARCHAR(10) NOT NULL DEFAULT 'no'--15-Have large ear ?
  ,Q16              VARCHAR(10) NOT NULL DEFAULT 'no'--16-commercially hunted ?
  ,Q17              VARCHAR(10) NOT NULL DEFAULT 'no'--17-Two hooves per foot ?
  ,Q18              VARCHAR(10) NOT NULL DEFAULT 'no'--18-Covered with a protective plating ?
  ,Q19              VARCHAR(10) NOT NULL DEFAULT 'no'--19-Horns ?
  ,Q20              VARCHAR(10) NOT NULL DEFAULT 'no'--20-Live in desert ?
  ,Q21              VARCHAR(10) NOT NULL DEFAULT 'no'--21-one horn ?
  ,Q22              VARCHAR(10) NOT NULL DEFAULT 'no'--22-Have fleece ?
  ,Q23              VARCHAR(10) NOT NULL DEFAULT 'no'--23-domesticated?
  ,Q24              VARCHAR(10) NOT NULL DEFAULT 'no'--24-Fly ?
  ,Q25              VARCHAR(10) NOT NULL DEFAULT 'no'--25-opposing thumb ?
  ,Q26              VARCHAR(10) NOT NULL DEFAULT 'no'--26-weight >400 pounds ?
  ,Q27              VARCHAR(10) NOT NULL DEFAULT 'no'--27-thin tail ?
  ,Q28              VARCHAR(10) NOT NULL DEFAULT 'no'--28-land based ?
  ,Q29              VARCHAR(10) NOT NULL DEFAULT 'no'--29-Prehensile tail ?
  ,Q30              VARCHAR(10) NOT NULL DEFAULT 'no'--30-nearly hairless ?
  ,Q31              VARCHAR(10) NOT NULL DEFAULT 'no'--31-powerful arms ?
  ,Q32              VARCHAR(10) NOT NULL DEFAULT 'no'--32-Live primarily in soil ?
  ,Q33              VARCHAR(10) NOT NULL DEFAULT 'no'--33-Body in segments ?
  ,Q34              VARCHAR(10) NOT NULL DEFAULT 'no'--34-Flat body ?
  ,Q35              VARCHAR(10) NOT NULL DEFAULT 'no'--35-Many cells to digest its food of a stomach ?
  ,Q36              VARCHAR(10) NOT NULL DEFAULT 'no'--36-more than one cell ?
  ,Q37              VARCHAR(10) NOT NULL DEFAULT 'no'--37-Spiral shaped shell ?
  ,Q38              VARCHAR(10) NOT NULL DEFAULT 'no'--38-Protected by two half-shells ?
  ,Q39              VARCHAR(10) NOT NULL DEFAULT 'no'--39-attached permanently to an object ?
  ,Q40              VARCHAR(10) NOT NULL DEFAULT 'no'--40-Have spikes ?
  ,Q41              VARCHAR(10) NOT NULL DEFAULT 'no'--41-Have a shell ?
  ,Q42              VARCHAR(10) NOT NULL DEFAULT 'no'--42-Have a tail ?
);

insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q5) values(1,'Frog','https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Australia_green_tree_frog_%28Litoria_caerulea%29_crop.jpg/1200px-Australia_green_tree_frog_%28Litoria_caerulea%29_crop.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1) values(2,'Salamander','https://www.macmillandictionary.com/external/slideshow/full/salamander_full.jpg','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q4) values(3,'Snake','https://s3-us-west-2.amazonaws.com/melingoimages/Images/88454.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q4,Q7) values(4,'Crocodile','https://upload.wikimedia.org/wikipedia/commons/b/bd/Nile_crocodile_head.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q4,Q7) values(5,'Alligator','https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/American_Alligator.jpg/1200px-American_Alligator.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q4,Q6) values(6,'Turtle','https://upload.wikimedia.org/wikipedia/commons/f/f4/Florida_Box_Turtle_Digon3_re-edited.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q3) values(7,'Shark','https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fdam%2Fimageserve%2F1004792742%2F960x0.jpg%3Ffit%3Dscale','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q3) values(8,'Manta Ray','https://aldf.org/wp-content/uploads/2017/05/cownose-ray-updated-16x9-1200x675.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q3,Q8) values(9,'Fish','https://images.pexels.com/photos/45910/goldfish-carassius-fish-golden-45910.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500','yes','yes','yes');



insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9) values(10,'Mole','https://cdn.mos.cms.futurecdn.net/mXef9pWQ6wzGKdfog5mnTn-320-80.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9) values(11,'Shrew','https://www.pestwiki.com/wp-content/uploads/2017/04/Shrew-on-rock.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9) values(12,'Elephant','https://upload.wikimedia.org/wikipedia/commons/3/37/African_Bush_Elephant.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q14) values(13,'Kangaroo','https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Kangaroo_Australia_01_11_2008_-_retouch.JPG/1200px-Kangaroo_Australia_01_11_2008_-_retouch.JPG','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q14) values(14,'Koala Bear','https://www.animalfactsencyclopedia.com/images/315xNxkoala-portrait.jpg.pagespeed.ic.QI_ThmQEAo.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q13) values(15,'Unknown','https://cedarnews.net/wp-content/uploads/2020/03/unknown.png','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q13,Q15) values(16,'Rabbit','https://cdn.mos.cms.futurecdn.net/65xDQxBV26qkgupGHbJSSZ-1200-80.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q12) values(17,'Dolphin','https://www.indianapoliszoo.com/wp-content/uploads/2018/04/Dolphin_Jackie-Curtsresizedresized.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q12) values(18,'Porpoise','https://cdn.mos.cms.futurecdn.net/32nfwF2izYqprutR4eDZDK-320-80.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q12,Q16) values(19,'Whale','https://api.time.com/wp-content/uploads/2019/11/great-whale.jpg','yes','yes','yes','yes','yes');

insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11) values(20,'Horse','https://ichef.bbci.co.uk/news/1024/cpsprodpb/1245A/production/_103224847_horsea.png','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11) values(21,'Zebra','https://cdn.mos.cms.futurecdn.net/HjFE8NKWuCmgfHCcndJ3rK-320-80.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q18) values(22,'Rhinoceros','https://upload.wikimedia.org/wikipedia/commons/6/63/Diceros_bicornis.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q20) values(23,'Camel','https://upload.wikimedia.org/wikipedia/commons/4/43/07._Camel_Profile%2C_near_Silverton%2C_NSW%2C_07.07.2007.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17) values(24,'Giraffe','https://a-z-animals.com/media/animals/images/470x370/giraffe_10.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2) values(25,'Bird','https://images.unsplash.com/photo-1535083783855-76ae62b2914e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2) values(26,'Penguin','https://upload.wikimedia.org/wikipedia/commons/0/08/South_Shetland-2016-Deception_Island%E2%80%93Chinstrap_penguin_%28Pygoscelis_antarctica%29_04.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19,Q22) values(27,'Sheep','https://a-z-animals.com/media/animals/images/470x370/sheep2.jpg','yes','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19) values(28,'Deer','https://fossilrim.org/wp-content/uploads/2017/01/Our-animals-pic-white-tailed-5.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19) values(29,'Moose','https://www.newshub.co.nz/dam/form-uploaded-images-ordered/2020/03/07/GettyImages-999573748-moose-1120.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19) values(30,'Antelope','https://a-z-animals.com/media/animals/images/470x370/antelope2.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19,Q23) values(31,'Cow','https://upload.wikimedia.org/wikipedia/commons/0/0c/Cow_female_black_white.jpg','yes','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q11,Q17,Q19,Q21) values(32,'Hippopotamus','https://www.theanimalspot.com/wp-content/uploads/2019/01/hipposmall.jpg','yes','yes','yes','yes','yes','yes','yes');

insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10) values(33,'Coyote','https://upload.wikimedia.org/wikipedia/commons/9/9c/2009-Coyote-Yosemite.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10) values(34,'Wolf','https://www.nationalgeographic.com/content/dam/animals/thumbs/rights-exempt/mammals/g/gray-wolf_thumb.ngsversion.1474903828879.adapt.1900.1.JPG','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10) values(35,'Dog','https://www.nationalgeographic.com/content/dam/animals/thumbs/rights-exempt/mammals/d/domestic-dog_thumb.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10) values(36,'Fox','https://i.pinimg.com/originals/37/07/42/370742e43fa9ec81ec136b9bd351e871.jpg','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q27) values(37,'Cat','https://www.northeastanimalshelter.org/wp-content/uploads/2020/04/IMG_7034-300x300.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q26) values(38,'Walrus','https://a-z-animals.com/media/animals/images/470x370/walrus.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q26,Q28) values(39,'Bear','https://upload.wikimedia.org/wikipedia/commons/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q26,Q28) values(40,'Tiger','https://www.gannett-cdn.com/presto/2020/04/11/USAT/503d4cf6-8d8b-4b1c-aa9a-ce2aef464124-AP_Virus_Outbreak_Tiger.JPG','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q26,Q28) values(41,'Lion','https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Lion_waiting_in_Namibia.jpg/1200px-Lion_waiting_in_Namibia.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25) values(42,'Baboon','https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Olive_baboon_Ngorongoro.jpg/1200px-Olive_baboon_Ngorongoro.jpg','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25,Q31) values(43,'Orangutan','https://upload.wikimedia.org/wikipedia/commons/b/be/Orang_Utan%2C_Semenggok_Forest_Reserve%2C_Sarawak%2C_Borneo%2C_Malaysia.JPG','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25,Q31) values(44,'Gorilla','https://a-z-animals.com/media/animals/images/470x370/gorilla4.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25,Q31) values(45,'Chimpanzee','https://www.irishtimes.com/polopoly_fs/1.2781686.1473178774!/image/image.jpg_gen/derivatives/ratio_1x1_w1200/image.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25,Q30) values(46,'Not animal its Human','https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQe88qYYmZD1bqBkAhAIBUFlX-BMDNhI0BRB0YQAIDPHLGAXiun&usqp=CAU','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q25,Q29) values(47,'Monkey','https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Macaca_sinica_-_01.jpg/1200px-Macaca_sinica_-_01.jpg','yes','yes','yes','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q1,Q2,Q9,Q10,Q24) values(48,'Bat','https://ichef.bbci.co.uk/images/ic/256xn/p024fxrf.jpg','yes','yes','yes','yes','yes');

insert into Animal_KBS (id,animal_name,animal_photo,Q32,Q34) values(49,'Worm','https://upload.wikimedia.org/wikipedia/commons/3/30/Regenwurm1.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q32,Q34) values(50,'Leach','https://media.beam.usnews.com/15/5a/c1c4b06c43f382d18eae99569182/leech.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q32) values(51,'Flatworm','https://upload.wikimedia.org/wikipedia/commons/f/f2/New_Zealand_flatworm_4.jpg','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q33) values(52,'Centipede','https://upload.wikimedia.org/wikipedia/commons/2/2e/Lithobius_forficatus.jpg','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q33) values(53,'Millipede','https://learnenglishteens.britishcouncil.org/sites/teens/files/styles/article/public/field/image/millipede-on-moss-mat-000032221220_small.jpg?itok=jTdCP61H','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q33) values(54,'Insects','https://fee.org/media/18517/insect_collection.jpg?center=0.7416666666666667,0.52166666666666661&mode=crop&width=1920&rnd=131303490260000000','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q33,Q41,Q42) values(55,'Lobster','https://www.factzoo.com/sites/all/img/invertebrates/crustacea/red-red-lobsta.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q33,Q41) values(56,'Crab','https://upload.wikimedia.org/wikipedia/commons/1/12/Liocarcinus_vernalis.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q35,Q39,Q40) values(57,'Sea-anemone','https://wonderopolis.org/wp-content/uploads/2012/01/sea-anemone_shutterstock_21850051.jpg','yes','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q35,Q39) values(58,'Coral','https://imgix.bustle.com/inverse/d7/59/d0/4d/8e60/4af3/b67e/1e74c3f46fe2/when-the-water-gets-too-warm-coral-lose-their-zooxanthellae-and-turn-white.jpeg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q35,Q39) values(59,'Sponge','https://i.insider.com/56d4ca64dd0895681b8b46a0?width=1100&format=jpeg&auto=webp','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q35) values(60,'Jellyfish','https://upload.wikimedia.org/wikipedia/commons/4/44/Jelly_cc11.jpg','yes');

insert into Animal_KBS (id,animal_name,animal_photo) values(61,'Protozoa','https://guidancecorner.com/wp-content/uploads/2018/07/Phylum-Protozoa_compressed_com.jpg');
insert into Animal_KBS (id,animal_name,animal_photo,Q36,Q37) values(62,'Snail','https://upload.wikimedia.org/wikipedia/commons/6/69/Grapevinesnail_01.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q36,Q38) values(63,'Clam','https://upload.wikimedia.org/wikipedia/commons/a/ad/Clams_on_Sandy_Hook_beaches_-_panoramio.jpg','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q36,Q38) values(64,'Oyster','https://images.immediate.co.uk/production/volatile/sites/23/2019/07/Native-Oyster-cluster-c-David-Smyth-3-d8184cb.jpg?quality=90&resize=620%2C413','yes','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q36) values(65,'Squid','https://images.theconversation.com/files/262841/original/file-20190308-150693-xpab44.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=1200.0&fit=crop','yes');
insert into Animal_KBS (id,animal_name,animal_photo,Q36) values(66,'Octopus','https://kids.nationalgeographic.com/content/dam/kids/photos/animals/Invertebrates/H-P/octopus.ngsversion.1396531103222.adapt.1900.1.jpg','yes');