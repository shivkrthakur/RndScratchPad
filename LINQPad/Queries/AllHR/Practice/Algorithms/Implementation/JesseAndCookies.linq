<Query Kind="Program" />

void Main()
{
	JesseAndCookiesUsingHeap();
}

// Define other methods and classes here
void JesseAndCookiesUsingHeap()
{
//	int [] NK = Array.ConvertAll("6 7".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("12 2 3 9 10 1".Split(), Int64.Parse);
	int [] NK = Array.ConvertAll("92 2280".Split(), Int32.Parse);
	long []  N = Array.ConvertAll("9660 9902 5775 2183 3974 7742 576 8786 7615 5575 6287 5495 161 3520 344 805 786 3802 4843 7424 634 7916 6989 3499 1216 1293 9965 6299 7899 4763 7272 9785 8469 395 1034 8763 8003 9464 5081 2064 4401 6850 8792 1603 7547 3354 8827 887 8151 2470 9995 7228 8198 5600 1829 8814 5282 3930 2481 6873 9165 497 2158 1752 878 8448 7862 7685 7988 3536 8227 8863 8663 1823 8510 7065 6927 610 4220 7096 7685 6992 976 5081 2389 1844 9843 8741 9582 3479 420 4136".Split(), Int64.Parse);

//	int [] NK = Array.ConvertAll("3 10".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("1 1 1".Split(), Int64.Parse);

	int n = NK[0], k = NK[1];
	//Console.WriteLine(string.Join(" ", N));
	MinHeap	minHeap = new MinHeap(N);
	int count = 0;
	long curValue = minHeap.Pop();
	while(minHeap.Peek() > -1 && curValue < k)
	{
		long nextVal = minHeap.Pop();
		long newVal = curValue + 2 * nextVal;
		//Console.WriteLine($"curValue:{curValue} nextVal:{nextVal} newVal:{newVal} k:{k}");
		minHeap.Push(newVal);
		curValue = minHeap.Pop();
		count++;
		//Console.WriteLine($"curValue:{curValue} nextVal:{nextVal} newVal:{newVal} count:{count}");
	}
	//Console.WriteLine(curValue);
	Console.WriteLine(curValue >= k ? count : -1);
}

void JesseAndCookies()
{
	//OUTPUT = 2;
//	int [] NK = Array.ConvertAll("6 7".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("12 2 3 9 10 1".Split(), Int64.Parse);
//	
	//OUTPUT = -1;
//	int [] NK = Array.ConvertAll("3 10".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("1 1 1".Split(), Int64.Parse);

	//OUTPUT = -1;
//	int [] NK = Array.ConvertAll("3 200".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("5 6 7".Split(), Int64.Parse);

//	int [] NK = Array.ConvertAll("5208 1920428".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("81735 72279 80206 91179 53258 89833 82627 78124 24337 16333 35352 52250 98429 26022 29947 79310 74708 71776 88568 27476 19382 18678 8391 74194 4752 17878 88481 93312 63028 9102 22447 693 50341 86336 52954 59526 16019 99008 37943 7558 83577 37716 9946 39634 3379 68896 98371 11717 83890 50760 93712 28772 20278 95662 99920 33949 22162 45159 20257 87013 7362 94493 71357 67995 9326 21176 89225 59907 73744 39866 30579 62247 21021 65928 33353 71645 51978 79486 33756 75251 59390 36613 43653 40009 24574 63988 20595 92499 25539 3834 43803 45637 63975 40006 7717 62271 99350 4565 87423 46244 50945 80904 16542 99260 95341 26876 852 12898 57227 3301 50761 71266 14804 23059 45708 18620 12933 57041 4505 9481 55349 76725 26077 64127 49833 85866 60334 53924 87059 68792 98597 2710 13944 1787 96834 24134 63774 73383 16506 28438 53625 64464 16259 68076 69084 1769 58504 99585 41929 87248 52096 13703 32103 18370 72681 75734 85126 70450 10957 57605 26250 57182 42945 65334 4330 32371 96248 36618 1324 76545 50880 71615 63182 75985 11785 22005 38504 42978 12622 67704 53847 20157 49749 99449 50365 16737 76144 70085 76802 44728 25322 23008 15569 85028 33067 78213 99200 18734 80419 88008 83858 77267 4562 1702 36045 72976 16711 81786 72110 10346 71332 97495 30355 99623 45010 18558 63521 85766 33658 52685 64225 98547 13112 50430 7345 21463 59984 91930 35758 36586 36787 64957 35493 34938 36953 6214 15171 29464 91041 22969 8566 53844 74312 92011 88031 83678 30635 93837 5054 98522 93834 705 70510 29918 52085 33883 56294 93770 85824 43637 50087 33838 49669 34052 53025 18689 16191 52776 12016 17596 10301 32659 76055 93074 31542 30231 97878 92483 26019 33858 58922 33324 8758 5685 8088 18189 83464 65400 55443 86422 67097 42199 29560 42303 76599 63219 25897 27298 34179 16764 96888 60400 91593 99240 27238 71285 33748 46703 50029 65879 51368 30949 62983 68070 17409 59822 67591 81681 67899 73112 60701 93247 71620 86250 68677 66008 11408 70279 34897 45942 50646 82409 76073 18080 53529 12524 2152 13755 75070 73710 50759 9688 63798 25895 52168 21136 30300 84740 20746 18329 32776 6323 50055 63162 40815 85067 19872 86360 51858 22870 37953 45878 37431 12727 80982 83282 56963 1649 56451 90061 27047 9691 44350 66149 24808 40693 26319 34781 9931 47237 16554 63870 76587 83634 50828 49077 28152 76954 19990 52848 11875 65971 63963 74884 3210 68066 31584 40285 51540 82855 96065 11070 77305 88273 81688 84936 52123 86855 62898 67262 89141 29626 85714 44195 54706 16805 22803 27610 34365 72266 33123 73310 84607 95941 7635 36920 773 27095 68611 33273 30472 5487 9675 7028 10836 73744 50769 16664 90487 79378 99826 89845 19469 59015 82728 76170 3457 36437 10010 46452 77098 25950 67436 26413 67812 7828 55162 7780 15270 74622 9686 26670 79837 1943 53753 2501 59912 69452 33145 51096 28302 13718 43547 23109 8746 67616 2926 42613 16261 53459 94553 14758 29943 17251 43657 27754 25866 14140 35050 4312 15162 49375 13500 58484 40934 44828 18242 97912 98536 63570 64195 78734 89989 60798 74263 7124 15860 83432 40519 99831 79707 42376 90032 26262 27723 76819 10118 65137 25499 76695 33813 21277 65245 85096 77555 56597 59955 80138 52748 17062 34451 27417 20222 23480 69660 90510 14170 13632 90355 89018 38407 79277 16105 23527 2786 27350 81137 10158 39134 15497 31269 94589 41539 80938 94854 54233 58800 65713 9333 42608 34728 78099 49915 24507 31765 77530 18145 41077 61133 28709 17805 94422 72079 62461 73221 17711 5347 6362 73499 65341 70357 99278 3694 53364 97315 75406 560 6970 74355 95226 94737 10552 35506 75551 44803 17903 54925 99516 93357 62260 4162 22007 10274 36839 80660 34396 92933 47361 71414 18612 40129 9381 59724 99472 97000 73650 96759 56631 19508 93555 42338 11309 5713 53725 82180 65803 40502 71049 34652 97522 46042 5302 19127 97924 1186 12384 69112 85166 16763 81109 29521 87819 25878 4024 87747 14781 82678 76462 35813 15699 68122 32373 27048 35627 28326 99178 57659 83607 8731 31125 9808 38029 83157 38411 57520 81133 387 91273 98085 89232 56731 56426 91708 94913 38318 43066 30633 67381 47808 87234 41068 67277 34191 58455 17777 30246 40931 33386 48044 39488 52574 8435 69704 74224 91131 88026 88832 29786 59332 44434 67007 29107 99074 61476 89426 95521 32038 30587 61657 88469 69914 32998 30434 48805 23711 33865 44073 98972 72213 54960 1524 18975 12486 65776 54642 68548 74728 74594 82303 82285 26593 5099 11189 15086 37982 48056 6230 43337 34558 27686 84191 41919 97302 40558 9751 23020 96924 24883 87101 41645 31848 52590 88866 30697 44715 84578 67700 83278 54766 21592 70034 93174 27067 66660 41927 99383 58561 52038 73978 93845 47292 27680 50816 6866 4659 94145 34371 66161 63181 49822 44737 3784 29335 39110 27339 32472 97007 81077 43054 81629 91468 41928 55004 13822 30881 98216 87974 37829 53793 71679 47505 48975 13973 10558 29043 58726 99168 78501 44038 96129 73571 52145 99302 192 75152 45380 61333 79182 25090 72570 8317 29795 83512 8452 26135 40376 93351 47905 61884 96234 61744 59799 33206 92414 67494 9925 88580 30707 25647 94143 92906 79651 89915 64030 91158 58360 86643 85070 43687 8672 75578 80561 80656 85942 5156 5454 25313 98197 49032 63805 46111 39853 18927 85279 51689 49065 52616 80703 73000 16765 90203 4546 25108 29366 85967 79451 31317 96056 33478 33760 91646 93648 9934 74439 75825 4799 88898 63148 1360 16243 47192 88665 32904 26545 83307 21259 39650 50030 81878 86094 41635 52240 4657 44605 41231 55877 56286 95199 81886 47318 11774 84636 31726 76927 11731 8947 78002 62333 34379 29636 36819 57944 14752 19791 22807 31735 53434 37554 73095 21366 38638 12477 1893 85681 97789 7590 36484 8733 86761 40104 15743 7676 30364 24665 16182 61764 24562 86081 63555 78645 72521 21979 22667 20444 25292 51481 78491 10087 27325 74632 59490 7707 37283 9419 42688 93782 47736 40198 53408 23337 27826 31340 59329 37942 55663 50009 9576 86136 50462 65278 77844 90932 74607 97557 51152 51405 83340 19384 74972 67974 80106 130 67729 81296 19488 20872 28252 17620 38154 66047 77072 60569 33685 2379 84634 56977 32325 76726 77383 69892 82876 82757 74896 82602 88142 16095 16624 75429 94726 61194 86957 31324 71485 88463 80437 20438 71404 13980 56452 7626 87131 71056 19487 14718 87028 66864 2087 39685 20125 83718 7518 87701 85207 61706 4084 31032 93572 54543 62031 4930 44743 66328 14564 68715 96280 85099 99215 25748 21546 41383 8859 29032 83798 56173 31524 25534 15196 49066 59570 90469 53013 2734 19602 47927 14396 75840 58490 8516 67268 14287 65318 26039 51247 19671 13 58659 90180 44245 62712 18 27026 46195 3356 26437 87868 73464 46037 44186 86886 69059 50828 20708 46518 69249 47364 62285 52960 67480 80839 98986 36965 24155 6260 61960 57590 47497 77522 36731 10891 98156 38065 56288 26019 97361 80430 8466 63734 85755 10783 39456 17764 75554 67129 10408 18296 27154 93015 77053 68223 57848 14427 55218 16970 70880 15810 52769 84503 33573 43861 31770 64886 58672 29550 60147 38864 93063 43143 94883 7009 31922 95292 28299 1522 77371 6537 45425 73843 87887 9446 31469 89907 91211 62844 29037 6685 38357 38958 54809 17710 36706 37782 99880 83999 62991 43464 53302 13823 66354 91861 52267 10311 43334 97669 31157 84456 6435 24010 55336 269 2251 49733 45535 52771 19141 46946 35254 54666 38948 27485 64110 82264 71214 69166 24526 78362 96404 51263 41302 75099 76646 88040 35237 32500 9938 30344 60033 96041 45865 59582 20052 38149 4396 77926 34199 77097 86151 32498 52216 95801 51357 96059 28170 78460 49513 45001 7083 35040 32755 44821 66551 26613 74942 8697 3312 12719 71354 9519 84424 40023 41552 10467 97120 56279 10414 11387 99813 19832 73161 88381 46361 34210 6168 61007 15064 92763 99646 6728 89461 82496 30431 24967 48764 82767 28287 82246 49206 28992 83434 99288 33531 90655 19680 5246 36596 35977 99338 42938 23689 62498 56220 14760 48759 2939 81371 68078 23489 86231 98595 2618 89045 47290 57092 86694 67747 12529 11365 25837 96321 56436 99492 53134 96574 59117 10466 5914 76377 67919 45164 63277 57521 93837 52273 45229 51110 46319 72649 97795 15375 44272 92516 97576 75319 96901 23262 45960 40983 64160 76384 67183 4843 13150 43420 90941 64499 79160 10503 62769 39193 30706 53577 72191 67760 8913 98693 78615 27515 97089 24732 46373 28774 65546 15769 14219 75996 65988 36419 39108 68720 84664 62634 1307 81066 11342 79087 25292 98931 89765 40313 326 16298 95350 38990 3833 54487 26250 19177 79859 56860 5874 41240 39488 25083 68926 48076 74360 16705 16798 3045 27632 43749 84043 5436 97486 98066 896 57382 72262 90461 27713 18255 51672 61953 70199 53794 86092 33045 37486 29299 24063 46596 98907 87629 69076 92006 63150 35013 52718 7487 34109 28801 23180 21217 33987 72374 44819 85491 29983 15975 83096 89653 19427 14088 24058 11362 20707 47192 70203 61298 86492 89059 60285 28507 90920 28875 60840 41944 50614 22790 46035 96282 13344 7111 34182 99433 57014 66896 79552 3111 20776 12413 18186 58271 22187 71473 40445 50463 61179 14004 64196 81728 84688 28570 62373 12763 14145 40595 20741 38354 19784 36848 10840 52526 73188 46107 22281 14457 37287 97149 63326 43039 92242 47294 41377 44333 30798 14304 85725 58345 87646 8180 58333 310 45285 73759 26082 45422 66677 81208 2085 87432 69008 84488 16895 9120 96000 21505 25933 80208 46115 23130 39671 40821 87572 32456 64715 92623 33881 24981 93468 38532 36181 71044 32682 38862 30488 70754 3347 50104 69613 12439 72033 94427 21272 34599 52096 88252 24277 72948 15737 95357 45636 36373 89848 38981 76316 23922 76074 36900 59037 40020 63213 64138 37319 65616 74474 65009 8260 75679 14088 38383 31526 56808 20530 17948 39243 46609 45366 71584 84658 28963 41630 21097 97973 20684 16733 84277 98005 7240 79312 72291 85488 11933 85360 36148 8277 15214 33992 67582 66684 80868 10859 89659 89087 1500 8229 66085 88293 34851 43824 72063 41007 27148 26049 83840 82411 26525 81424 41372 22458 50651 2137 89764 9020 34586 38478 38983 47801 84956 40890 8818 86110 54072 91248 78018 62762 54743 70808 841 88980 17345 7712 31860 12412 75970 66265 77337 35992 20611 84122 70586 93545 57803 33442 93177 51898 65142 15992 11112 77892 10153 38453 19720 87721 99983 88949 66855 48076 90994 75399 81295 77095 99853 40724 89433 51279 60539 60476 49424 73921 14451 8569 16142 71245 70170 98985 67874 54573 50015 79051 74183 83759 78459 31521 27559 39503 63129 88243 22908 74464 33944 68666 69639 77143 14348 17963 79867 9674 82497 58176 83421 17729 45143 31798 77348 37426 26217 21629 11502 54386 65005 15154 94775 15034 16637 25571 49255 28631 47851 39916 70802 73205 13241 85508 25828 74377 24254 98868 870 58837 45071 44859 3097 11799 96829 9617 43803 71123 45206 43400 78324 64550 890 26982 91731 62608 34413 4823 35025 63685 19295 13098 72258 77888 81839 41940 84167 44540 37288 17828 81018 48985 99146 1246 80020 73706 85432 28298 59895 13168 56784 20510 12266 30969 8822 87499 86244 72892 90159 35265 64763 18937 48904 92619 97034 50484 13722 23845 16827 46354 85325 39721 51394 22736 34874 97606 39422 86402 62070 43396 98703 71259 31100 87158 24637 64622 15497 62393 48984 54221 49111 17629 5566 20213 17066 31025 31317 81893 76397 37508 18108 2142 78 64804 39348 35568 35293 16693 56572 96494 15161 11758 49500 45199 74533 94839 67994 7675 50258 91051 32428 81353 38846 92042 11742 92361 57376 99577 94468 36238 59513 11872 70378 48218 52595 34992 3185 49288 69626 44943 45174 77616 93293 25868 82788 84598 19573 1251 36210 52416 94225 10371 45096 36319 73064 56786 44968 28898 33049 83789 45410 7952 63673 94950 32097 25379 40846 50298 56242 70824 33499 79945 91501 19332 50602 22184 17761 4362 31246 59034 76009 65855 12673 73685 40344 98012 62644 49787 16824 87843 63303 51563 59713 12613 30912 84814 63594 94865 92418 69091 79373 83116 98148 24873 23915 26273 18754 84107 60878 49228 55102 99033 45610 64137 88780 69735 60649 19233 90142 85820 22377 33498 81677 76047 50609 10321 20737 45744 19808 24209 37196 25792 37439 43877 41043 61150 46872 55285 13154 99445 23448 95912 24108 22216 83488 32394 101 19109 5412 66161 60187 49504 91294 46006 33156 15779 38214 9686 21251 50470 35011 44359 57300 31701 51999 68072 32230 33323 2412 63785 81079 89122 62916 2344 3532 63086 26228 37657 44119 63831 20698 70520 67214 66779 83033 54801 36350 42074 21430 60270 94968 23404 10736 36746 20896 36138 23615 87737 72259 26316 70443 73953 43839 15982 79550 71976 34881 23322 17167 29213 33339 86703 13745 76849 73894 23380 45054 83891 54913 65515 98085 24855 67231 33932 1047 5792 64113 97335 58450 14533 71375 35979 89535 2294 90161 9775 34378 91057 41194 91906 15002 26879 18036 45873 81372 81475 9144 8070 13185 714 6906 33503 56294 38234 59770 95936 154 87412 25128 34420 11538 92764 81180 39017 8659 81503 39125 88954 85805 44113 64532 34565 95291 37294 63318 69488 35191 71678 88424 33708 31676 73640 97461 27427 18839 56038 49393 5677 13985 80075 42 44969 57101 48133 61863 97499 5869 64341 81892 69982 77771 41645 12782 96242 18207 69926 59548 27646 34941 26819 39836 39928 19066 57391 80959 9899 64722 53450 15218 24204 72639 97323 12060 41167 84936 33984 65012 54340 95832 86214 16232 19375 88563 82659 35234 59541 6999 10032 36989 43618 69960 19013 46353 37417 62712 16017 69000 60839 17944 92355 93181 21458 64665 53797 7602 99951 55208 93010 26948 18519 68734 94149 19984 59565 45902 11934 5200 99321 73876 14088 23223 45700 798 36929 22836 47526 44850 45795 61763 83131 22031 96100 53462 6141 5706 60831 93325 89798 80827 80791 36036 40364 68221 62663 86643 62886 15530 89321 31971 44144 98542 20876 54280 20876 40009 52619 34180 30315 75274 97539 57147 74001 1323 57964 98273 59905 34007 34435 15161 15437 13235 58329 45040 68806 65050 42569 10425 88582 73916 28207 27256 24317 72769 33736 53009 69786 21678 22837 72119 21398 9226 33983 12797 90825 73818 23622 70717 57137 58323 30627 93126 21247 91936 98679 30847 77192 54448 73787 45352 57250 87310 59250 3646 21758 35241 90033 27039 45373 25707 62602 26039 69232 56145 42304 25823 22517 66703 85803 46438 80348 34368 19019 63217 90882 19617 30052 50361 14721 13957 63137 70388 12790 51858 205 94798 59294 38628 24244 98142 87715 88084 66001 6498 90799 83867 43986 8606 90166 44936 13246 10635 28705 60753 93948 42570 74940 97517 7687 44468 92403 85481 95096 87997 80050 89427 60636 36858 74526 63027 60455 30114 75357 32842 45674 54398 8347 36295 81146 8217 88848 21378 12469 63931 18413 57230 64044 14133 62850 28413 82636 89523 33670 27217 28791 74819 81070 65781 62408 50883 69948 78396 35036 35946 85868 76852 92879 60481 96939 42754 27025 70438 38326 28998 11779 67482 636 87439 67052 4854 58609 6405 13192 95752 66116 74853 93535 72587 82644 76032 58066 93755 92280 7840 23147 81500 9610 93305 12369 80021 65616 83538 37394 29520 55648 94298 91094 11920 68674 10826 9296 81300 79380 37924 46871 14316 94591 77890 2098 92233 60154 96366 52338 14592 88959 93209 89079 82527 18111 5855 49691 28730 45120 5376 9402 25737 30996 43360 27292 9102 6271 22344 60339 48697 81214 33405 1157 49936 32024 48643 14228 94353 88554 17098 55606 89801 844 52748 89298 6600 65841 27850 23701 29675 82055 20680 82696 94498 85358 83210 86381 23617 295 72432 38464 54033 55569 57770 15839 10079 43556 18628 48001 39471 9329 9171 40834 75620 78288 54768 65774 96016 43144 80362 73711 78819 38562 72389 92598 5639 51057 69434 64587 7385 36629 55812 23786 54706 92131 47237 84067 85581 4550 64418 26133 58442 59806 23299 61288 51086 27518 43446 22084 95238 13251 79749 63034 85339 39927 5134 3202 43328 49769 3283 36623 21891 37393 33134 97651 98723 8053 32931 90706 64764 18783 34201 91648 92755 66926 48805 7770 25293 47459 2840 41001 43575 24625 65020 18908 57544 35011 96112 80947 9839 96779 41426 50842 26833 84686 25434 66744 45956 33013 13063 37679 75490 41933 47221 55185 77730 88997 83536 94101 30098 6826 71955 48762 52328 88615 49626 63443 20219 88500 88433 11739 91788 37822 45231 29888 14834 2029 17856 85667 34007 34639 78304 73251 47811 45260 48615 82157 80297 31854 70124 32456 79074 31875 94144 75294 41380 35962 33628 36594 88662 37246 59734 33962 99480 76139 2376 57436 62848 79154 31837 43736 825 44815 62915 23743 25705 90713 29205 27513 84858 48455 4445 5079 81769 99411 11726 2278 65236 28252 7864 84688 92427 49269 22294 84878 93528 67058 36139 75214 96681 16720 83170 43886 27648 37627 6722 25951 75156 92995 85600 29775 9859 83398 20530 88271 38310 25344 2815 67237 4751 81916 7857 35303 47204 81836 98089 85548 38219 80978 61376 48210 51884 51185 96599 54133 83415 35272 53351 99318 21115 26824 59975 74377 79582 72922 37613 9133 87212 2719 52114 82730 29974 14002 83517 60901 26213 30251 19039 62213 96233 77420 90335 18379 53852 65905 42535 75765 78175 86578 70916 99005 55590 79531 83197 37470 198 5121 88687 13500 47596 35503 17483 29834 52378 43698 40291 40236 89022 14491 17011 92111 94844 63490 74821 21092 4039 81048 8820 73394 99147 49685 44068 53470 17286 3456 57058 38244 5710 4882 42629 13184 48615 26548 63902 14261 45778 18094 24239 61115 77370 62743 74585 47720 27311 29751 67350 24455 25434 20121 28363 79860 45826 74074 55760 51300 81650 46813 42420 17505 89924 72292 91877 15572 13177 83377 36386 21609 91588 49108 50766 16068 18298 97654 77151 94418 79042 6756 56301 86603 21461 80344 23623 71333 80745 82885 97042 80733 86385 20938 89871 48611 20333 19023 97573 32576 59648 25831 55472 96032 62816 84458 26286 57008 83015 1657 4658 74059 18615 10390 20273 93919 31694 52620 94277 45467 40596 18840 4138 21345 2914 69686 48306 89949 77207 95511 37066 33685 3572 13532 82680 25767 59176 16242 17157 62821 75163 86836 50770 24958 2589 89434 23080 75644 33432 78723 2010 12574 78649 85275 78361 29418 48077 88319 5024 69565 5045 8961 24984 48365 16808 56552 1442 89906 64197 64086 7195 19926 99461 65108 37003 48350 13935 63086 21490 13927 65443 30089 46199 99857 23643 79647 84674 13243 8784 20083 80218 55004 22901 69196 22305 77202 45194 61229 11241 46580 34221 58770 45581 25304 74625 60242 90361 38442 93208 78111 91063 13872 93950 46484 80861 16340 64012 61530 70456 10767 97958 39756 74808 58857 87049 97289 96516 66511 78091 7084 93413 24608 23726 18653 67603 638 44149 6920 50943 55622 9692 41375 98646 25314 20273 35050 20588 17982 24405 18363 50756 78110 85460 83515 10018 9292 50369 84219 94342 19764 85975 26704 54042 43067 49664 13628 93111 87631 36231 22890 81271 9635 11860 74379 12569 86043 96128 88184 39562 12884 91663 88373 53494 92466 80003 26862 6723 32536 53604 35790 62906 59156 22187 37000 58665 99812 36085 61671 38057 62797 59352 69094 75358 81185 66746 36892 24046 53141 48719 20275 37124 60121 30655 4964 98793 51887 19579 6973 67042 81648 18017 32648 93214 99170 22010 43726 17006 69705 29287 41576 23699 9435 2902 67960 21543 74898 90072 88054 68322 32129 10684 41125 78226 64533 58361 6760 9089 69672 97821 91163 74189 7408 5001 35981 69714 36983 58136 62225 13843 39403 15820 27266 95893 74182 7147 224 26350 6458 36273 47696 3464 91356 82363 1354 33878 24243 98377 72102 50816 46831 98785 48940 12927 9203 98890 16469 70675 9462 44556 86221 49934 63714 14788 33291 40341 86921 30656 71804 88591 65086 89887 61829 73096 82021 58606 37322 43182 53685 27042 74538 44825 38440 72141 96286 93950 60947 51423 356 2273 53413 95118 54930 22796 19544 82493 76977 3934 33986 49879 49709 16296 19139 98711 39968 34740 94985 62504 79215 86148 63746 94959 60745 53592 94584 23786 78941 34777 39578 73121 9485 22238 92987 41934 9304 50113 88986 18537 35737 11661 41409 50471 63472 65502 88846 99745 31761 82772 82672 91688 42501 62954 92686 56502 95199 84892 8474 44844 28327 14565 28300 71818 29327 19079 60991 87579 69591 34930 90813 88029 31298 13555 45410 74992 40738 63876 39227 11839 77703 34173 55444 25105 77679 31990 33611 79186 8602 63091 57247 90832 7431 18934 76018 96374 30261 85500 45588 94587 31033 64295 54866 29821 63968 60497 73013 46829 84718 71417 52607 60811 40701 4654 97117 69946 36130 10943 34253 36443 53645 71527 72612 36414 45971 1525 33773 47962 26210 17974 75817 51200 9663 36137 16784 31362 55619 51674 96818 75635 97699 71314 45633 60235 78235 30679 84297 83839 74741 39346 73470 89045 55599 57096 85250 69928 32376 5099 36675 12670 41376 18663 8509 61230 56975 15641 555 25387 21221 59041 74176 63327 83146 12642 68444 82610 86840 69643 45787 53181 39484 19888 98065 53138 82618 97107 34259 23257 94993 478 90968 89981 9558 3970 51023 15608 65999 15327 20998 83081 21784 78427 29174 51291 82417 30350 66783 80234 88716 23325 5617 32360 34959 73967 82558 74574 1826 12901 27703 60142 55907 24238 83499 83803 86854 85359 54522 21869 19184 16597 1577 3507 779 87819 11280 11871 28051 32582 25933 13407 36675 51703 41470 40756 46916 99296 76181 11241 80048 15275 23180 88819 4725 21261 36998 93965 11855 2471 17873 27103 73517 9286 91720 70353 98955 25466 97259 69522 12225 53936 25694 81828 41892 38737 10119 89157 224 12414 32449 25213 50476 89265 84371 27969 5487 96582 94377 95201 5278 8377 70028 35945 41524 65815 17389 54071 26756 12727 89049 26922 18465 87908 49408 44558 98964 74816 10409 9575 6388 56369 54638 50267 85165 40367 26855 45438 70854 12592 36561 87281 12423 45183 71622 90056 78146 56967 12363 64797 20606 11760 95022 82508 5513 38721 25370 66214 95345 37929 93932 76937 87748 56778 47240 78956 83122 43885 29234 1423 65535 55558 66350 62396 34278 99700 71832 54703 21951 22382 95280 29910 57659 53368 6763 80866 35510 56534 92947 47878 15708 52880 41151 71722 62716 89772 44376 53306 84145 17483 47003 70615 56667 73873 14581 50251 67860 90221 18772 47107 63145 43211 22599 68939 31232 3731 45488 21596 97663 2555 86606 66767 88053 31491 41411 57637 84761 42207 88559 72403 98242 36171 89042 80316 51326 52000 92576 50760 8510 93582 99063 59007 36510 84402 30058 81315 18573 97222 9003 58966 29881 86378 32177 54610 72447 30499 12480 34337 45306 62972 52942 94158 48309 45377 33531 92949 75927 30813 28049 49651 47290 29043 42369 2949 9030 15926 56347 61530 57663 4235 37407 5668 94012 78092 42523 75332 97419 49578 30455 55749 55119 42851 30344 20719 44615 91955 93823 32193 87256 11565 75995 24195 27638 61748 9289 20981 39809 88390 18068 5053 2205 84751 36297 8452 11779 4587 54356 81628 15676 72416 17880 63380 25435 60189 77510 38927 5974 32459 67443 65338 50356 86007 1464 24110 48575 36079 79922 69679 50062 4288 49084 47425 78810 37328 95496 86485 6533 72628 48597 60415 25525 3397 25496 8574 95428 48316 59520 44057 83368 1722 73236 305 4463 16522 51551 62940 48167 102 38179 37636 38907 2359 89998 4645 75908 78955 54034 69012 39704 25114 87557 12126 84016 75212 45510 54518 27831 60601 1194 56035 92576 60370 41226 94738 96754 6276 26735 42838 40949 69611 97206 7104 72573 35300 68984 31118 62936 69135 34614 63486 24731 30070 13796 61051 38704 92597 83105 86323 72796 11968 28437 35763 18077 21078 42597 60623 63643 75900 44345 50320 4043 20762 34025 73739 48526 69662 34985 35969 42340 56915 48875 51381 86649 33612 65877 66351 40697 98624 67956 4132 64470 66406 3230 39525 17500 89024 49071 89620 16441 68939 64065 84418 60045 21725 54428 90235 89613 43156 75318 99060 79890 81518 74519 3512 94636 30275 94223 27617 2828 43666 1809 13854 16983 70936 72924 42331 81444 23050 76368 18080 45035 13155 36369 53679 41314 12591 31196 48146 77787 56491 5800 15707 18292 83580 69852 462 74217 79509 40534 41852 2107 63024 88289 94406 58923 40948 32364 26203 13880 14574 29492 57642 68442 69417 69947 7642 19088 65262 33891 46282 40321 28116 40824 71145 83443 56901 65130 23541 13826 18261 42323 55986 64345 5380 62779 45600 53420 67106 13687 72959 79631 12171 76451 36357 17888 50066 95197 85758 17352 38989 70865 74181 5331 61131 48772 55833 79854 51904 9886 64112 65653 37564 60705 69235 66378 64986 23839 68400 29289 97216 28128 42227 48145 83352 4865 98187 10889 22611 13778 45170 42320 70862 44939 98024 43996 77188 82270 13937 33028 9801 39089 42282 19203 24523 41373 75404 50147 38594 81275 96722 52788 14620 79122 78749 62211 77221 570 21290 64331 54957 71528 15690 20850 76833 26088 98436 43548 4928 66500 57356 66362 24539 11759 75971 5071 72387 87222 96679 54341 78228 18295 70475 54162 80867 24826 84912 5065 61327 27784 43989 58396 97041 82119 84886 9695 68677 98741 51271 99808 51449 82175 10918 59646 52614 15511 85610 17200 65725 92944 45489 18736 35285 72631 87006 84394 70216 6210 1505 95516 74051 45599 29235 93129 16851 6840 17752 85239 68217 56933 56239 19476 64256 83952 68825 16377 38536 13997 87705 54294 230 99205 37515 26786 10737 68809 48662 88524 97374 88872 70126 9502 94006 66616 93809 15145 46537 37383 24199 17954 81762 63681 72827 30441 27252 93328 27853 72124 7446 23092 43510 11541 48415 46443 82922 86761 16146 33943 92074 31585 10762 14004 25833 71759 54067 63288 68865 30916 96987 71516 82035 27976 81948 86423 42431 31366 8542 56334 65211 14039 29480 29429 24864 52489 97771 70861 34413 28219 30514 48359 63370 43768 11062 35710 38825 50075 56728 48717 60867 12571 60595 73165 27302 96973 81644 10405 19443 9336 4648 16611 68172 75259 32933 6959 94720 27773 71978 34892 78537 42609 92404 62050 89506 61614 91954 85106 36866 9710 12261 34045 50363 30254 68652 40075 74385 40001 22354 19184 65837 32542 46402 96279 94632 41999 22245 49431 10255 30730 78332 90304 75228 14329 60686 200 11136 95862 47827 65686 50318 94814 15155 53736 73011 7796 4853 87986 23191 97750 73593 15760 13935 78881 16674 54404 61808 92723 47937 50853 10671 99973 29338 261 91653 72364 77407 53297 75660 15187 92357 18832 43273 43415 75508 92829 95230 68742 21635 56896 92518 4908 41186 1213 73844 37077 57018 97146 1782 42084 72231 70052 12172 24590 86924 93535 17197 86331 68115 7900 32260 61033 34111 32234 12474 54520 12159 98579 69075 45653 27064 35244 26672 80499 99858 80080 62136 43806 57071 54830 6561 35188 76613 30911 67218 4238 14253 24342 5706 71280 73198 98621 39850 37647 21498 53194 37927 10039 66669 50631 12770 55563 91993 62667 13179 7908 67074 26261 54960 13736 84409 2489 38134 24049 84461 28360 74569 10017 96195 78195 66497 44475 22045 82920 75019 26848 2084 11721 85533 92772 43004 28756 67550 7673 17067 7425 67066 53734 60784 13014 50683 31713 1634 62857 83852 41240 73741 10378 61698 87620 52101 64474 97799 60231 29007 32087 80066 52924 65807 71441 45553 53750 59473 82470 19766 1185 55351 64871 70944 41256 51663 60184 17410 99209 11101 52492 52395 77148 14836 49756 62385 4937 57947 88873 28641 33248 8584 51063 41157 36317 95140 8720 75117 26126 21927 9304 74067 96653 79061 97439 2125 43763 81809 73188 96248 31653 70807 96350 94122 81028 24360 36308 44285 16068 74650 34583 5141 63941 44679 27238 1143 45189 14757 52708 99487 51907 49457 2993 67793 63837 59492 18587 43142 22586 87261 39871 87546 82208 82660 93110 8787 32999 14293 54595 89657 40221 87342 26208 46435 62876 56112 86711 36578 57563 77690 92617 70756 83930 11602 47171 94603 57055 15387 26166 13477 36873 12403 16321 84478 56003 49995 92120 44475 11619 30338 42607 56265 58032 74490 39105 4540 30274 94974 33113 90765 93355 68064 34771 64884 37355 95665 66817 51526 15559 11201 35517 61756 39384 17266 37955 43176 27307 190 13747 49254 68122 41271 54855 29280 57426 77282 44463 68061 1569 18795 58946 12230 30713 91578 23693 88753 49910 34487 41994 76135 19276 73067 99017 66322 37915 52445 39420 14378 51007 75030 13823 34976 36617 39257 23950 90656 95410 43508 67932 541 91505 72866 50306 97529 43801 85479 24939 70090 83937 8191 58447 34770 40572 28492 47698 21949 71653 62099 14361 71442 17296 51806 98046 9666 13149 72674 37983 69331 45674 4373 73141 65038 89340 3084 56996 23112 37507 74649 34541 19691 98967 65579 31952 9062 6123 89440 83434 34307 59289 21202 62496 24638 32955 16597 23699 414 97989 61901 50771 2239 92917 19587 33920 62916 62018 33716 13909 43508 96609 74999 78843 45059 65686 34180 35030 55360 83451 2449 52049 7402 35133 3931 39971 12968 8693 73173 14119 97840 44168 73461 77281 12796 13105 50570 25914 16500 42406 11426 40673 70863 88687 79947 15363 21574 30272 95817 14700 24852 31100 14876 63571 71442 91679 97773 6730 62543 91875 97853 89696 41416 43004 9343 47125 11651 75644 29672 21589 10792 18818 57172 29707 89617 39457 99867 88103 93601 85232 51719 27951 49988 46434 94177 45139 44095 67125 54272 76883 95642 22653 79873 46836 92461 73526 16401 50829 21978 25280 66931 63914 84351 11238 83016 25411 1343 29823 29503 30469 10183 890 43039 74469 44315 81449 44228 32260 23639 58707 81679 71309 90297 9336 61651 96240 97047 41226 70106 12257 13378 43072 60948 89371 93462 22569 61123 27594 65857 47661 63589 29335 38898 8568 31822 74285 92134 41837 67286 17583 90817 81828 38609 31459 98376 99528 68593 59754 45101 54057 92778 97681 50364 87422 18199 95363 7822 89443 95372 1786 87775 31619 80499 74580 10781 4314 58844 3943 38330 10247 45325 10092 79512 63441 91808 52379 52392 99336 74051 30231 98771 91547 63958 62577 40995 57377 37848 13622 22643 59696 96320 13766 24989 37900 92104 84669 54736 21192 74698 48597 65753 68855 8568 58339 45046 14062 52784 34557 55181 34529 86009 64601 6525 36425 94386 64245 97547 8949 46958 4705 29273 15292 48471 74596 43231 59632 38395 15926 52787 69691 36501 77633 56994 72210 73161 4180 23040 78798 69955 85861 14620 72864 2225 87612 90142 45782 97842 76131 31069 9935 2965 48034 63401 10503 57893 65065 20468 38559 53554 66733 81296 59383 28120 34423 22152 98611 28721 9821 63998 946 68328 12877 68822 22697 88511 18717 39321 71553 76215 26273 31443 84673 48643 48670 53146 3631 18908 70695 4779 78810 98214 9365 18984 91575 9480 19814 51830 55996 5767 79719 51777 92835 38219 1653 19545 52069 61034 33457 62470 86363 65062 9588 62034 75091 22173 64528 93554 26231 71140 32549 6737 78183 95198 24137 64035 34971 19814 26029 87992 62747 4785 99538 23770 97594 14723 54737 62515 34934 55508 72515 6616 50856 36195 57568 22253 43210 29565 83487 62214 31302 58980 10405 21837 15398 66210 44943 79950 85331 36649 85729 98421 33867 85750 11615 78809 77466 66474 30904 10386 49812 32342 64081 8920 82058 29782 15092 5279 37669 82700 15969 66401 85858 13331 57915 85298 33717 92487 68700 41604 97574 14964 5024 55525 25070 25115 93118 51414 950 47283 90176 2218 10120 50839 95521 68035 46656 12342 34322 48403 93387 6746 26448 90626 48064 97169 38707 49172 55695 22028 42211 4719 44246 10855 55795 39464 11093 79138 55547 32033 5691 39700 75043 43960 12470 24347 78118 17256 26749 34523 61190 69158 36420 89268 10907 94963 42702 3190 7906 73486 23107 16201 74762 29648 99547 58018 49329 82182 14100 43323 64083 34148 20648 57395 60753 50708 89432 18558 3486 79892 88453 14888 7267 50609 79759 76368 13023 53037 7095 30878 67000 38014 5354 45891 40785 74126 66829 23448 66435 88470 54654 91738 52758 58657 39955 71335 9094 96747 78262 93266 68415 71495 11619 66970 51681 7770 16649 36854 9515 13736 79021 88747 90449 7594 54076 46022 57216 85056 73801 42937 7132 22956 2364 5515 74806 77481 50958 66820 52857 19948 60486 98870 22799 47816 9909 47556 68015 1395 28919 96480 90070 41713 91331 48625 9874 85262 31775 94224 81364 56260 92197 73306 87537 11113 75902 19548 70057 60399 90970 57968 93650 53412 65864 42841 54692 6358 24837 49279 66525 67532 17775 60874 25636 47348 7451 13181 65842 27750".Split(), Int64.Parse);

	//OUTPUT = 5
//	int [] NK = Array.ConvertAll("8 90".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("13 47 74 12 89 74 18 38".Split(), Int64.Parse);

	//OUTPUT = -1;
//	int [] NK = Array.ConvertAll("8 8467293".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("13 47 74 12 89 74 18 38".Split(), Int64.Parse);

	//OUTPUT = -1;
//	int [] NK = Array.ConvertAll("92 22803452".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("9660 9902 5775 2183 3974 7742 576 8786 7615 5575 6287 5495 161 3520 344 805 786 3802 4843 7424 634 7916 6989 3499 1216 1293 9965 6299 7899 4763 7272 9785 8469 395 1034 8763 8003 9464 5081 2064 4401 6850 8792 1603 7547 3354 8827 887 8151 2470 9995 7228 8198 5600 1829 8814 5282 3930 2481 6873 9165 497 2158 1752 878 8448 7862 7685 7988 3536 8227 8863 8663 1823 8510 7065 6927 610 4220 7096 7685 6992 976 5081 2389 1844 9843 8741 9582 3479 420 4136".Split(), Int64.Parse);

	//OUTPUT = 0;
//	int [] NK = Array.ConvertAll("4 10".Split(), Int32.Parse);
//	long []  N = Array.ConvertAll("52 96 13 37".Split(), Int64.Parse);

	//OUTPUT = 14;
	int [] NK = Array.ConvertAll("92 2280".Split(), Int32.Parse);
	long []  N = Array.ConvertAll("9660 9902 5775 2183 3974 7742 576 8786 7615 5575 6287 5495 161 3520 344 805 786 3802 4843 7424 634 7916 6989 3499 1216 1293 9965 6299 7899 4763 7272 9785 8469 395 1034 8763 8003 9464 5081 2064 4401 6850 8792 1603 7547 3354 8827 887 8151 2470 9995 7228 8198 5600 1829 8814 5282 3930 2481 6873 9165 497 2158 1752 878 8448 7862 7685 7988 3536 8227 8863 8663 1823 8510 7065 6927 610 4220 7096 7685 6992 976 5081 2389 1844 9843 8741 9582 3479 420 4136".Split(), Int64.Parse);

	Array.Sort(N);
	int n = NK[0], k = NK[1];
	Console.WriteLine(string.Join(" ", N));
	int count = 0;
	long nv  = -1;
	Queue<long> queue = new Queue<long>();
	for(int i = 1; i < n; i++)
	{
		long cur = N[i], prev = N[i-1];
		//Console.WriteLine($"cur:{cur} prev:{prev}");
		if(cur < k)
		{
			if(queue.Count > 0)
			{
				long tgt = queue.Peek();
				//Console.WriteLine($"tgt:{tgt}");
				if(tgt < cur && tgt >= prev)
				{
					nv = prev + 2 * tgt;
					queue.Dequeue();
					queue.Enqueue(nv);
					count++;
					continue;
				}
				else if(tgt < prev)
				{
					nv = tgt + 2 * prev;
					queue.Dequeue();
					queue.Enqueue(nv);
					count++;
					continue;
				}
			}
			nv = N[i-1] + 2 * N[i];
			//Console.WriteLine($"nv:{nv}");
			queue.Enqueue(nv);
			count++;
			i++;
		}
		else if(prev < k)
		{
			nv = prev + 2 * cur;
			count++;
			break;
		}
		else break;
		
	}
	if(N[N.Length-1] < queue.Peek()) count++;
	if(nv == -1) Console.WriteLine(0);
	else if(nv < k) Console.WriteLine(-1);
	else Console.WriteLine(count);
//	Console.WriteLine(nv);
//	Console.WriteLine(count);
//	Console.WriteLine(k);
}


class MinHeap
{
	int capacity;
	int size;
	long [] items;
	
	public MinHeap()
	{
		this.capacity = 10;
		this.size = 0;
		this.items = new long[capacity];
	}
	
	public MinHeap(int capacity)
	{
		this.capacity = capacity;
		this.size = 0;
		items = new long[capacity];
	}
	
	public MinHeap(long[] input)
	{
		this.capacity = input.Length;
		this.size = 0;
		items = new long[capacity];
		for(int i = 0; i < capacity; i++)
		{
			this.Push(input[i]);
			//Console.WriteLine(string.Join(" ",this.items));
		}
	}

	public int GetLeftChildIndex(int parentIndex)
	{
		int index = 2 * parentIndex + 1;
		return index;
	}
	
	public int GetRightChildIndex(int parentIndex)
	{
		int index = 2 * parentIndex + 2;
		return index;
	}

	public int GetParentIndex(int childIndex)
	{
		int index = (childIndex - 1) /2;
		return index;
	}
	
	public bool HasLeftChild(int index)
	{
		return (GetLeftChildIndex(index) < size);
	}

	public bool HasRightChild(int index)
	{	
		return GetRightChildIndex(index) < size;
	}
	
	public bool HasParent(int index)
	{
		return GetParentIndex(index) > -1;
	}
	
	public long LeftChild(int parentIndex)
	{
		int index = GetLeftChildIndex(parentIndex);
		return items[index];
	}
	
	public long RightChild(int parentIndex)
	{
		int index = GetRightChildIndex(parentIndex);
		return items[index];
	}
	
	public long Parent(int childIndex)
	{
		int index = GetParentIndex(childIndex);
		return items[index];
	}
	
	public void Swap(int indexOne, int indexTwo)
	{
		long tempValue = items[indexOne];
		items[indexOne] = items[indexTwo];
		items[indexTwo] = tempValue;
	}
	
	public void EnsureCapacity()
	{
		if(size == capacity)
		{
			capacity *= 2;
			Array.Copy(items, items, capacity);
		}
	}
	
	public long Peek()
	{
		if(!IsEmpty())
			return items[0];
		else return -1;
	}
	
	public bool IsEmpty()
	{
		return size == 0;
	}
	
	public long Pop()
	{
		if(!IsEmpty())
		{
			long item = items[0];
			items[0] = items[size - 1];
			size--;
			HeapifyDown();
			return item;
		}
		else return -1;
	}
	
	void HeapifyDown()
	{
		int index = 0;
		while(HasLeftChild(index))
		{
			int smallerChildIndex = GetLeftChildIndex(index);
			if(HasRightChild(index))
				smallerChildIndex = RightChild(index) < LeftChild(index) ? GetRightChildIndex(index) : smallerChildIndex;
			if(items[index] < items[smallerChildIndex]) break;
			else Swap(smallerChildIndex, index);
			index = smallerChildIndex;
		}
	}
	
	public void Push(long item)
	{
		EnsureCapacity();
		items[size] = item;
		size++;
		HeapifyUp();
	}
	
	void HeapifyUp()
	{
		int index = size - 1;
		while(HasParent(index) && Parent(index) > items[index])
		{
			int parentIndex = GetParentIndex(index);
			Swap(parentIndex,index);
			index = parentIndex;
		}
	}
	
	public long [] Items { get { return items; }  }
}