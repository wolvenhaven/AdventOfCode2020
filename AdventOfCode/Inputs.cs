using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class Inputs
    {
        public string expenseReport = @"1509
1857
1736
1815
1576
1970
1567
1778
1508
1833
1377
1890
1375
1396
1102
1639
1818
1469
1138
1333
1906
1557
1686
1712
1990
1930
1761
1881
1551
1627
1801
1728
1960
1407
1832
1842
1393
1870
1295
1528
251
1945
1589
1850
1650
1793
1997
1758
1477
1697
1081
1825
1899
1171
1104
1839
1974
1630
1831
1671
1723
1811
1489
1647
1486
1107
1786
1680
1942
1640
1112
1703
1315
1769
1966
997
2010
1635
1196
383
1986
1860
1743
1756
1555
1111
1823
48
1953
1083
1804
1933
1626
1895
1807
1669
1783
389
1821
1883
1114
1587
1941
1725
1646
456
1550
1939
1975
1324
1201
1018
1001
1402
1885
1481
1633
1781
1622
1822
1559
1696
1510
1251
1732
1790
1813
1695
1121
704
1964
1984
1763
1656
1183
1771
1276
1764
1810
1992
1213
1840
1318
1965
1943
1549
1768
1506
1949
1739
1852
1787
1570
1988
1357
1909
1837
561
1994
1777
1547
1925
1897
1817
1677
1668
1982
1667
1753
1041
1826
1961
1797
1765
1720
1835
1688
1705
1744
1977
1971
1775
1782
1661
1385
1162
1755
1846
1674
1698
1882
1766
1820
1531
1577
1710
1382
1246
1864
1702";

        public string passwordList = @"6-9 z: qzzzzxzzfzzzz
2 - 4 s: xgmsdts
6 - 7 k: khqpsvk
1 - 3 k: knkqh
4 - 11 z: lwnzgzlmpvz
11 - 12 m: mmmmmmmmmmtz
1 - 10 l: lllllllllml
2 - 5 q: qjmzhdpmmnqpwptn
7 - 8 t: ttkttbtwtt
7 - 10 k: jmmlgrkmwkzkhbhr
4 - 15 m: xrnxpvxsqfmfmtmqg
5 - 7 s: swsskgwsbzv
1 - 3 w: fqbnmlbvnw
3 - 4 f: btqj
1 - 6 l: llwlll
14 - 19 s: ssnskstsssssssgcssq
7 - 8 c: ccccccccccc
3 - 6 p: fbzpfpp
6 - 7 m: mmmmmmm
4 - 7 b: tbdbgdmbbtbb
5 - 6 z: zzxczzzmttpl
12 - 13 c: fcjcbkcvqfpcj
4 - 7 h: hhhhhshgjhrbmhh
2 - 5 x: gxfdt
7 - 15 c: czpmdcgzsclgfvnf
4 - 7 s: djrssdsrxs
3 - 18 k: bxnktckkrklkkqkbhkk
4 - 6 d: ddddddds
1 - 4 s: rssssss
15 - 18 c: cccccccccccccccccc
5 - 7 k: kkdkfqkkkc
2 - 3 p: fppp
3 - 4 n: qnnn
11 - 12 r: crrgrrrmrrrrrnrnrgcr
6 - 7 w: wwwwwvww
3 - 12 k: kkvwkwkkkkmkkmkkkkkk
2 - 3 z: vzlzq
13 - 15 z: wxwdzgwdfwnzzqgms
7 - 16 l: lllllllllllllllll
2 - 7 x: rxblxnrvxtfpxtxdxmtw
5 - 6 c: ccccvl
13 - 18 h: nhhhhhhhhhhhthhhhjh
7 - 9 r: znrrjxrhr
4 - 9 q: qqqgvhqqc
2 - 16 v: vvbvvvvcvvnvvvvvvv
15 - 16 p: pppgppppppppppbzpp
7 - 8 c: cxcccccxccc
2 - 11 l: kvhbvkqbbwlccxflpshz
7 - 8 g: ggvgkgsw
15 - 16 d: dddddddddddfddqd
9 - 10 h: hhhhhbhhhb
6 - 9 b: bbbbbshxdbbbb
7 - 13 k: vxkkkkkkkkskk
5 - 18 t: tttttttttttttttttlt
1 - 6 j: kjjjjtjj
2 - 10 c: cdjcccncqvccc
3 - 5 m: thmmm
7 - 11 m: mmmmmmmmmmjm
6 - 10 x: xxxxxxxxfxxxqsrxx
1 - 7 l: lllllllll
3 - 4 l: bccgqfqmw
11 - 14 j: jzjjjbxjdwrwjs
8 - 12 g: xjhglhggcgbggltl
1 - 4 s: sssss
5 - 6 v: cghvcx
6 - 8 t: tttttttrtt
2 - 3 j: jhzljj
1 - 3 j: djgr
4 - 8 m: mmmcmmmmmmm
2 - 4 m: wmxwkljhbnwzz
13 - 14 f: ffffxfffffffqh
2 - 5 f: dtwxj
8 - 15 t: ttttlntlttxtttttt
10 - 12 h: hhhhphhmhqhhhhgh
5 - 11 h: hkhmhjlglwbcmj
3 - 13 c: cccccqccccccccsccccc
1 - 5 q: qqqqqqq
8 - 18 h: hhhhhhhchhhhhhchhvh
3 - 6 g: cmlgzx
2 - 4 f: tfxxffv
2 - 11 w: wwlwswwwwwwkvwwwwwww
9 - 16 f: bfffffzfvqfbjpftffp
1 - 8 x: xxxxhxxxxx
9 - 16 k: kkkkkkckxhkkkrkg
10 - 13 c: ccpccxcccxccc
1 - 5 g: gmgktgpgg
1 - 7 b: kjblhbbbbbnbbf
2 - 11 x: xxxxxxxxxxx
13 - 14 n: nnnnnnnnnnnnvnn
1 - 10 p: szlkqswpvpr
3 - 4 c: cccc
2 - 5 v: hcxxggmqvtj
8 - 17 t: tttspltttmtphfqfr
11 - 14 w: wzqzwwwwcfzwwqww
7 - 10 n: cnnnndnnnn
11 - 13 z: zzzzzzzzzzfzz
2 - 5 l: hnfpwt
5 - 6 k: kkkkvfsd
5 - 11 f: ffgffffffffffdfffff
2 - 3 s: dskm
10 - 19 n: nnnnnnnnnnnnnnnnnnwn
3 - 4 b: fspwzjqblbljpbdvxbq
4 - 8 c: glcfckjs
1 - 4 l: lllzwlllllxblvlllll
12 - 15 f: tlfgzfffqfffffffwff
11 - 12 j: kjjjjgjjjjtj
6 - 14 c: cccccvcccccccc
2 - 7 l: lrllllbgzl
3 - 5 w: wwwwpw
11 - 14 m: mmmmmmmmmmzmmj
5 - 11 x: nqpxxbpgsjxjslxg
8 - 12 n: nnnnnnnznnnnnnnnnnn
6 - 8 p: ppppprpp
8 - 10 q: lscqkhvqvqq
2 - 6 m: kssmnmmjzfnhb
12 - 13 t: tgwtttttsbjbd
14 - 15 j: zjtjjjjjjjtzzjj
7 - 8 s: sssssqzsss
16 - 17 f: fffffffdfffffffff
13 - 15 w: mwrwwwlwpwpwwwl
3 - 6 v: hxvvvmpfw
3 - 10 m: hhjmpfctxwbrwpc
3 - 12 j: fvgbjhjqgnxp
8 - 9 v: vvfvvvvvvvqr
5 - 8 v: vvvbvvvv
6 - 7 s: hssrsssts
5 - 8 q: zqqqqsvq
8 - 10 d: rdhqphxncd
4 - 5 s: ssqss
4 - 14 z: zzzqzzzzczzzzxzzzc
3 - 4 p: pkpppp
5 - 7 g: gkggbtgggh
8 - 14 q: qqjqqqqvgqgqrtqqq
19 - 20 c: cccccccccccccccccqcf
2 - 5 l: hmldnrg
2 - 4 d: rddd
3 - 9 m: lwhhsmggbzvkm
16 - 17 w: jsltwwwwckhmrgwnw
5 - 6 q: qjqqwcbmq
4 - 5 d: dddddd
2 - 9 t: tksgtdbbtvkthtth
3 - 7 p: pnpnppptbsvlppjh
2 - 6 j: jjlvjjjj
16 - 17 v: ngvvbjvvvvlncvkvd
6 - 8 v: vjdvxvrq
13 - 14 m: mmmkmmmmmmmmms
8 - 12 x: xxxxcxxgxxxxx
11 - 16 n: nwnnnndpnnnnnnnn
2 - 17 f: fjfvfffgfffffcfwff
2 - 7 k: kkkkskk
7 - 8 d: dddgxdjd
6 - 14 b: rbbsbmbbbbqnlb
1 - 3 h: hrnr
4 - 7 g: xggzglphmfgvjzgpb
12 - 16 c: cccccccccccccccjc
1 - 5 q: qslvqhslbrkpzttq
10 - 16 n: nnnknnnnnznsnnznnnnn
3 - 5 z: lzzll
4 - 13 d: dqdldgdddddddd
5 - 8 n: nnnnxnjqnn
3 - 6 v: vwvvpv
3 - 5 t: lhttr
1 - 5 p: ppppbp
9 - 10 c: ccbbgdcrccknqwv
4 - 5 h: ghzrhkz
14 - 15 r: rrrrrrrrxrrrrrr
7 - 10 z: zzzzzbwzzgz
2 - 3 t: tzttttttt
1 - 2 k: mthj
4 - 11 r: rggkxrwsrvrcrbrrrrr
13 - 16 k: kkkkkkkkkkkkkkkkkk
8 - 10 z: zzzzzzxczvzzzzm
11 - 12 s: sssvssssssss
11 - 18 t: nlvmtdxttwtxthjpqm
1 - 19 x: qxxtxxxpxxxxxddxxkx
15 - 18 q: qsqqqplwpqhqmvtxjx
5 - 11 q: qvkkqxqqkrqfqq
12 - 13 l: fzsvglgwcllxllwmxl
2 - 12 j: sjqjdvrbfkgjphcr
8 - 9 f: fffffffffff
1 - 5 r: frrrm
2 - 4 v: sfmvjdvhrnltlwfshnwn
4 - 9 s: ssswsssslsssss
12 - 13 v: vvvvvvvvvvvnvv
11 - 12 w: wwwwwwwwwwww
1 - 3 c: grvsjs
5 - 7 p: ppxzppp
10 - 11 t: vttttttpnkhkttpjttt
11 - 16 g: ggggggggggpgtggj
3 - 13 t: cspcttmxlttgt
5 - 12 s: nssstgsqstssjbsbg
10 - 13 c: cgccccccdzcjlcc
5 - 6 j: jjjmnr
2 - 9 x: xxpxcxwdzxxxwxxxxx
5 - 8 m: phmcgvfnq
2 - 5 m: tmwkmmnmmx
10 - 11 n: nnnnnnnnnnt
8 - 10 p: pjpdpppmnhpczp
11 - 12 d: bvvdkhjddvdk
7 - 11 d: dddddcddddjd
1 - 2 m: mmmmmm
3 - 4 q: qqqqvmq
4 - 6 p: ppkqpgcnpfpct
7 - 8 z: zrbzzzzf
3 - 7 k: ktkklqk
1 - 4 n: fvbnxcrq
3 - 4 h: hcwh
4 - 12 r: hptvxxkrzkjz
3 - 14 k: kkkkkjkkkcnsmkk
4 - 5 c: vwncp
11 - 15 t: xqtttttsdtdtttj
2 - 3 q: thktq
3 - 7 p: fzppplf
1 - 7 d: phdzkqsxgm
7 - 8 g: gggggggg
1 - 4 v: llvc
14 - 19 b: bbbbsbbbbxbblbbbbbbb
1 - 4 b: bptc
5 - 11 v: vfvvpcfgvxvcvvvv
9 - 11 j: jjjjjjjjjjj
17 - 18 z: chbgftspdwsxkptfrb
8 - 9 d: nxlkdzznfszf
6 - 12 g: gggggggggggggggg
3 - 4 t: ttlt
4 - 9 c: csgclhqql
3 - 7 q: qqhglqfq
1 - 2 f: fffff
1 - 11 k: kkkkkkkkqkzkqkgkjk
10 - 13 m: mmmdpmwrmmmmgmmm
6 - 8 b: bbbbsfbb
4 - 5 d: fddqg
7 - 13 z: zzzzcqdfzzzzz
8 - 10 c: cccccccrczc
2 - 11 w: prwzrtwwqwsx
12 - 14 h: phhhhhhhhhhdhpthh
1 - 7 s: ssssssss
5 - 8 t: jtttbttntctttt
3 - 11 w: cnhwdwxwxwrwkww
3 - 6 w: wpwctmdrfh
5 - 6 n: nnnmslxnnnnn
11 - 13 q: qqqqqqqqqqkqqqqq
4 - 5 s: sfsscsczsss
3 - 11 x: crvfnxzscrx
3 - 4 l: ltqz
6 - 18 s: zsssssxpfpstssssss
3 - 8 l: lklwqllm
11 - 14 b: bbbbbwbbbbhbbbb
3 - 4 f: gtzf
15 - 18 m: mvmmmpmmmmzmmmzmmv
2 - 6 w: whwgkw
6 - 7 w: wwwwwgw
18 - 19 h: hhhhjhhhhhhhhnhhhjnh
1 - 6 c: xcccccpcccc
5 - 6 z: jwfczxdzchzx
3 - 6 z: zzzzzvz
3 - 9 p: jtcpzqgdpgpvtcp
1 - 4 p: wppp
12 - 13 d: nddddddddddrd
8 - 12 n: nnzgnbnnnncnnnnllnf
4 - 5 w: xmwlwwbwhlwdjdxznw
11 - 12 z: zzgzzmzzzzztzzzzz
9 - 10 w: rwlwwwwwwvw
9 - 10 w: wwwwwwwqwd
5 - 10 k: kkkkjkkkrk
2 - 10 x: nvxssnnmxsxxmdp
14 - 18 f: gfffffqffrtffcfffh
7 - 8 t: lbtkkltt
14 - 18 t: tttntttttttttrtttjtt
11 - 13 t: ttttvttttttkk
4 - 6 d: xnqdgwhdplnfnnd
3 - 11 c: qtktrztvcmcjcdptz
16 - 20 j: jjjjjjjjjjjrjjjgjcjc
11 - 12 d: dddddddddddjddsd
6 - 7 m: mwmmrrfltmm
9 - 10 t: ttmbjjtttttthr
1 - 4 n: cffnnw
2 - 5 w: twkkw
5 - 6 k: zkkkkkt
4 - 15 k: kkkkkkkkkkkkkkh
14 - 15 d: dddddddddddddvz
1 - 5 w: wwrsw
3 - 4 c: wtcq
15 - 16 j: hjjjvjjjjjjjjjjdj
1 - 4 n: nnnpnnnnnnnnnnnnznn
4 - 6 w: njhwvcpwwzclwbwd
4 - 6 w: rwwtvs
3 - 8 v: vvpjvvvvvvvp
1 - 16 t: tttttttttvttttttttt
2 - 10 s: ffkfgwlbdgnsnprc
5 - 10 v: pdsgvvtvvv
10 - 16 x: chjxpxmxvxxxcvkhjb
5 - 13 l: lkllsrjllllllcll
4 - 5 h: hhhlhh
3 - 6 z: zpbznrzzsbzzz
2 - 16 r: mxrrrbrxqsfvrhsrbl
4 - 7 q: qqvqqqh
3 - 4 s: ssnm
7 - 13 p: ppppcppptnqpkhplpppp
11 - 18 v: svmtvcvvvvvhfvlvvvv
5 - 12 n: nxjdnnnszcnnnn
1 - 3 n: tnmn
6 - 17 k: klkkkpkkkkkkkkkkkzk
12 - 17 d: dddddddddddjddvtdddd
5 - 7 c: ndcddjzcrxccgdcc
2 - 4 s: qkssssssz
2 - 5 d: rdhdd
9 - 10 b: jbbbbbbbbbb
5 - 6 j: xbhfjjgqjjlmjjjkr
3 - 4 d: lzdhbwb
6 - 7 j: jjjkjwzjkjjjv
17 - 19 g: gggggggggggggbggvgr
3 - 4 r: rrwm
1 - 7 g: dgjgbgrthgg
11 - 18 x: tsxqxxpnxzxxprcsxlrl
1 - 5 f: fvwwm
2 - 5 b: dzdvb
1 - 2 v: tvvv
5 - 7 j: jjcjwlw
3 - 11 z: cqkwrzqzfzbqlhssnfjm
6 - 9 z: zzzzznzzbz
12 - 15 l: rllllllllllllllll
2 - 3 t: dztg
5 - 8 r: rrrtxrrr
6 - 7 v: vqvvvvvvcv
7 - 8 l: lllxlllllf
6 - 7 c: ccclcdq
1 - 6 c: cctccvcccrv
2 - 7 n: nbnnnnnnnn
2 - 3 z: tznzg
6 - 10 t: svpwctktsstttvktttt
1 - 10 w: wwwwdwwwrcjwwxw
6 - 11 p: pstpqcpjppz
12 - 13 z: zzzzzzzzzzzszz
11 - 15 n: nnnnnnnnnnnnnnnn
11 - 12 n: nnnhnmntnntnn
1 - 5 f: fvfkmttffhmnf
14 - 17 v: vvvzvvvvvvvvvvvvcvv
9 - 10 x: tdxcxxrfzq
7 - 8 s: sssssshss
7 - 11 w: tndwtqcwchwlww
10 - 15 z: zzzzzzzzzqzzzzqz
2 - 7 d: dddddkddjdhd
11 - 12 j: xjjjjjjjjjdgjp
3 - 4 x: xxxh
7 - 9 q: ghqjtqqqfqhbqnhqqqfq
1 - 9 p: jpklbnmpnpnpdp
1 - 5 z: zzzzzzz
7 - 8 t: ttttttjw
18 - 19 s: sscsssssssssssssskss
11 - 14 f: fffffrffdfgxdfffkf
3 - 10 q: gqxqwzlxqqgdbqwcdnlk
2 - 11 s: jnhvsvklrlh
4 - 5 s: sssss
4 - 16 f: fffnfffffffffffff
1 - 5 s: sszsscspsmcrhqss
6 - 7 f: ffffffdf
5 - 6 x: xxxjxx
7 - 8 k: vcbrgpkhlrdzkxchkzrd
12 - 13 d: dpddhddddddgrd
11 - 12 d: ddddpdddddmbd
2 - 5 m: kmxxm
3 - 11 m: wmxmmmsfmmfmmm
10 - 13 x: xxxxxxxxxxxxx
3 - 5 r: kwztrmr
8 - 13 l: lpllllqxclfqzjj
5 - 9 j: hsqjjsstj
2 - 11 d: ddsdddddddd
13 - 14 j: jjjjjjjbtzjjjh
11 - 12 p: ppdpppzppzpppppmp
5 - 7 t: kstztjtttt
3 - 16 h: jhxrphhhkhhhhdhhph
9 - 14 v: vvvvtvvvvvvvvvvvv
4 - 9 q: qqhqmqqqqqgkfq
3 - 8 j: trjcpjbjwkks
9 - 12 s: smbssssssssjsj
8 - 9 l: llcpllvllllln
14 - 17 m: mmmmmmwmmcmmmcmmmmhm
1 - 7 j: fjqjvjjjwfsjp
1 - 8 k: kfnkfkkwfklkkkm
14 - 17 l: lltrxxllllslvltfnh
3 - 4 f: ffqdff
9 - 12 h: lwhhqrhdhdchdh
10 - 13 t: cttttttttrttttx
2 - 6 j: mmtmjjw
3 - 4 h: hhxh
4 - 11 c: cdfgtcddwsj
1 - 2 f: xmfff
7 - 8 x: rxqdphxtv
2 - 4 n: nphnzn
8 - 10 r: rrrrrrrrrwrrr
2 - 10 c: ckccccccclcc
6 - 13 j: vbqznjpjjzqvgqj
9 - 11 x: xxxxxpxxdxb
11 - 14 v: vvvvvvvvvvvvvhvvv
5 - 6 r: rbrrrg
12 - 13 d: dlrdlddddbdcd
6 - 13 x: xzxxxxrmjxhmxxxxjj
2 - 3 c: ccqcwc
11 - 17 n: nnnnnnnnnnnnnnnnnn
2 - 4 r: wrsrcrltvsh
14 - 15 l: lnltlllllmllllgllldl
8 - 9 m: mgmmmxqmsbmmhmm
3 - 4 m: npmmrbjr
4 - 11 n: kwfnhknwdfnpshtnw
19 - 20 x: pnzhdhxttngbxgxzzwxx
12 - 13 r: rrrrmrqvrprrmrlrr
12 - 15 f: lffffflffffjfff
7 - 14 x: xpxxsjxkxxxmpcm
5 - 6 b: fxfglbw
3 - 7 z: zzsmfzzzzz
7 - 15 w: gdhxwlgdqldtgpwkww
12 - 13 c: dcvdcqcsdcgcclsc
1 - 2 f: tfsffnff
7 - 10 c: ccccccccch
5 - 7 v: rvbkvnvh
3 - 4 z: jzdvgq
1 - 3 g: xgdggg
1 - 20 r: rrrfhrtfrrrqknhcrbhr
14 - 15 q: qbqmqqqqqpqqncqqqq
5 - 7 r: rrrrrrrrr
6 - 11 g: wcgggzbgwkhg
15 - 17 g: ggggggggggggggdgg
4 - 5 n: lnnln
4 - 12 q: bqvzcfvckzqrqnqqqqkv
2 - 3 b: brsb
6 - 9 z: zzzzzzszqzzzznzzb
2 - 7 h: kvmhjshb
8 - 10 f: zgffkrhfjfqbpqgqtht
12 - 13 m: cksxcmrrqrmsml
15 - 18 d: dmqxddddjbdhpddzdddd
5 - 14 f: fkpcnkwxbxkhqf
6 - 7 k: kfkckkkkkkkkkkkkksk
11 - 12 w: wwwwwwwwwwtwww
1 - 3 t: tctrtgkttt
1 - 2 l: llls
10 - 11 t: tttttttttst
3 - 4 n: nnnn
12 - 13 n: nnngnnnnnnnnnn
4 - 19 g: ggfkqswnrqfbblgwkkg
1 - 4 c: ckcm
1 - 13 b: bgbbbjbbbbbcb
6 - 10 h: khhxbzqhtqrh
1 - 4 v: vpvvs
2 - 3 z: zczz
2 - 4 s: nflsfms
5 - 9 r: xsrlrtmph
9 - 11 k: kkkkkkkkwkjd
2 - 19 m: smbmfpmwpmslmvmpzmjw
5 - 9 f: fmnwznffxqnpscffjdq
5 - 13 c: sfcsczccvntcngsd
10 - 13 f: sfffffrfzcffwff
4 - 15 q: qqqqqqqqqqqqqqwq
4 - 6 m: mbmdmkmmmnmm
8 - 14 r: rvrprrrkrrrrhs
7 - 15 g: zpdmdnjtgqjlxrgks
3 - 6 p: qpplqpfvpk
1 - 3 t: trtttqvtt
4 - 5 d: vdwdd
4 - 5 d: dddckd
6 - 7 w: hwxwwwwpw
7 - 9 m: xsqtmrxmrfjmw
12 - 15 v: vvvvvvvwvvvvvvs
6 - 7 b: bbbbbbd
15 - 17 b: bbbbbbbbbbsbbbvbbbb
7 - 9 p: ppkhgmmzp
16 - 18 d: xdddrdvddpdddrpddhp
7 - 11 v: fvpwgvbknbnvn
3 - 4 k: kkkwjktmslgjf
4 - 5 d: ddrdd
13 - 14 z: jzzwzzzzzczjkgvzzzz
1 - 2 h: fhskvjxhk
3 - 5 g: nggxfgpgjmg
12 - 13 h: fdgbxhdcrllhq
2 - 4 k: tscc
2 - 3 g: qgcvmgvgln
8 - 9 n: nnnlnnnjjn
2 - 20 c: crrccccrhcccctlccccc
1 - 7 t: ttmtvttttqtwtmt
11 - 12 v: vvsvvvlvvvbvvv
11 - 14 v: vvhtrvcvvsvbvvvvvvvv
8 - 9 s: ssslssskdsfs
5 - 9 h: hhhhvhhhbhh
3 - 5 f: mxtsffxssf
9 - 13 h: hhhhhhhhshhhmh
1 - 4 d: mdwdddddxjdx
11 - 13 k: kklkxkhkkkkkh
7 - 10 x: pnlzrxpxglt
4 - 12 h: hhhhhhhhhhhkhhh
9 - 10 v: vfvvmvvxmvvvvj
8 - 10 v: vvvvvvvvvs
5 - 6 d: ddddgdd
3 - 5 l: lptbcl
4 - 8 n: nwvnnnnnqbnn
11 - 13 h: hhhhhhhhhhhhzhhhh
3 - 6 j: jnvxjdsgj
4 - 7 k: kkkhhkkkkj
2 - 3 s: jsmh
4 - 5 b: bbbbdb
8 - 10 c: ccqcjccbccccc
7 - 15 z: gzzzzzczzzzzzzdzzm
7 - 8 g: gggrgggtggg
11 - 14 s: skssssvpssssjksssw
7 - 11 m: mmmmmfrmmmmmmg
7 - 8 b: zbbbbbszsbb
6 - 13 f: ffffnlfffffftfffff
6 - 13 v: vvvvvvvvvvvvv
14 - 15 l: llllllqlllllllf
14 - 15 p: ppppppppprpbptfppp
5 - 9 b: bbbbxbbbsbbb
10 - 18 q: xpnfpbxszqbftrbtqj
8 - 9 f: fxggtxvjffb
10 - 11 l: lwfkqllllftwllllll
6 - 9 k: kktkkkkkkkkkk
8 - 15 q: qqqqqqqlqqqqtsh
11 - 12 c: ccjcjccjcsrcccccswc
4 - 7 c: mldccmj
5 - 6 x: lvvxfc
1 - 4 p: bdppppp
1 - 2 q: qhxqq
7 - 10 x: xxxxctzxsxxxpxgkm
5 - 14 g: ctgbggjgqggpgmc
2 - 5 l: hlllclpllcqllrxl
14 - 19 w: wxmfxnshvhntvlxnhxw
17 - 18 t: tdttttttttttttttxz
1 - 2 b: bkxprpwkpckr
1 - 3 c: cccccccccjkccm
14 - 15 t: ttttttttttttttmn
5 - 6 g: dspggq
12 - 13 g: ggggggggggggg
8 - 9 j: jpjjjqjjjhgkj
4 - 5 s: psscc
1 - 5 c: cdhdcqfqjzkg
7 - 10 k: kkxkkkpkkr
5 - 7 k: xkkgckv
2 - 11 r: rrrrrrrrrrrr
3 - 4 t: zpjf
11 - 13 x: xxxxxxxxxxxxxx
3 - 4 w: cwcwr
1 - 2 q: qqqsbdmvs
1 - 3 k: xpkxnzkk
2 - 5 d: kbhddqrdxd
7 - 8 q: tpnqqqzqcpqw
4 - 5 f: fpxfr
2 - 5 k: kkkkxkk
10 - 19 n: nnnnnmnnnzncsnwbrbdn
3 - 6 z: ffzzdzzcrwb
2 - 3 k: kckk
3 - 4 k: wfzk
9 - 16 x: xxxxxxxxxxxxxxxxx
2 - 3 w: wwwl
4 - 10 r: ckfrpqvlwrmx
6 - 7 v: vvvvlvv
7 - 8 l: lqcbvvjlxbl
13 - 14 z: wzlxhhdczjwcmk
7 - 19 b: lcgclqqxsxphbsbmzlq
6 - 7 j: vjjjjtx
9 - 13 x: djsxbtxtcxxjxxxxxnx
3 - 5 s: ssxswsss
19 - 20 t: ttxktttttgtdttttttfs
8 - 9 z: zzzzzzzzxt
1 - 11 n: ntnnnnnwjndnn
2 - 9 g: gggzggggzgggggggg
11 - 12 x: xxxxxxxxxxxwxxx
1 - 2 x: cxxddnf
4 - 10 t: tcwtmhttcctd
4 - 16 f: ffffffffffffffffff
6 - 8 b: qmmdbbfcbbkbvfpbj
7 - 10 w: wwwwwmwwwp
9 - 15 q: tkqdqqqqcqqqqtkqqqq
7 - 8 x: zxxxlxxxx
6 - 7 r: hlrfrrrkrrrtrhjmmgl
4 - 5 s: bzhmps
15 - 16 h: nhhhhhwjhhhhhhld
2 - 4 v: vvvvv
9 - 12 m: fbmmmmpmmmmmjmmmml
16 - 19 c: bgcnldccctppvpsclpj
7 - 8 g: gggjgfgg
2 - 5 g: wptrhlbnzcstsqjmncgp
3 - 9 g: gjgdgzgvgglgvgnf
12 - 14 z: lzxwqwplwkzbnf
4 - 5 r: brrrr
8 - 16 d: sqnkpjdzjrlzdwbjjdgd
3 - 4 v: vvlv
9 - 11 l: lhllslllblx
4 - 8 f: ffflfbrfb
9 - 11 d: dddndddddwdf
14 - 16 b: bbbwbjzbbbbbbfbtb
6 - 14 v: vvvvvdvvvvvvvv
9 - 12 x: xxxxxxgxxjxxx
10 - 13 t: tttttttttptttt
3 - 4 t: tttt
6 - 9 l: gwlllwllg
5 - 7 f: fffffffff
4 - 6 b: bcbbhbgb
14 - 18 w: pbwkxhsjsvpwmlkwtj
1 - 17 f: ffffffffffffffffffff
11 - 17 j: jsqlmtmjpjsdjkcrrj
7 - 12 b: bbblbfbbbbbb
7 - 8 q: qqhqcngd
8 - 12 b: bhbbbwbcbbbgb
7 - 9 r: prrdmhmrrrrhjmpj
15 - 17 x: hxwxxxxxxxxxxxxxbxx
3 - 12 f: ffjkffffffdx
17 - 18 v: vvvvvvvvvvvvvvvvkv
5 - 6 l: llllll
11 - 15 q: ncbjqqcqdmbzkfhsq
1 - 3 c: ccnc
13 - 18 v: bpvpvvxhvghvlhvtkv
14 - 15 l: lllllxlsllllllxll
2 - 18 h: bwfdfgrmqjjwxhqzgh
11 - 12 j: nvftlpcbjjwjwvs
8 - 11 t: tthhtgtkttt
1 - 4 d: dncktlddldn
11 - 13 j: gdpdxkqjjmjnj
6 - 8 t: tttttltq
7 - 9 p: pwppppbpf
1 - 5 h: hhzxhpkthzhjh
11 - 14 k: gkkzkkhvkkmkkkfhkkpk
6 - 7 t: tttttvc
4 - 12 b: lbvbckvhgbpbcw
1 - 5 w: wwwxtbw
12 - 13 x: xxxxxxxxxwxzxwx
3 - 6 h: ghjhbhhq
9 - 12 z: zzzzzzzczzzfzzzzzz
2 - 16 g: mzxlgsnjnfzswlzb
11 - 16 r: rrfrtrzhrtcrmrdgv
3 - 4 d: gndc
3 - 4 g: gggggrg
10 - 11 m: mmmmmmmmmxj
7 - 9 g: gtgsxwgzgrjggvfxbkd
18 - 19 v: vvvvrvvvvvvvvvvvvhv
2 - 8 l: flpbnfnlczl
1 - 11 l: llllllllllll
3 - 5 j: jjjjljjjjjjjj
4 - 5 l: vwdlt
3 - 5 l: vllnw
13 - 14 z: lltbpkrqghqxczx
5 - 8 h: tfhhtsjhhhsddl
13 - 15 k: lztbvbqwhxzzkkklfnv
4 - 9 h: hpsbfqrrqpsrhwxdnrc
9 - 10 k: lkkdfvnwkk
7 - 15 p: qmvqqqpggvlxppp
10 - 19 v: xvvvgwwvvmvvvvgvjrrv
3 - 6 t: qtftptnttmt
4 - 16 c: qcsrwtcszkdjljfcnp
4 - 5 d: dddsd
2 - 3 b: hbwdg
4 - 5 l: lmldl
13 - 15 v: vvvvvcmmmfzppkvmv
6 - 11 k: pbkkskgpkjkdwkvkk
9 - 11 k: kktkkkkkkkq
4 - 9 m: mmmmctmmd
10 - 13 w: mjwwbwrwvktghdszxd
3 - 7 q: krcxxqvnpkhvbwpjkg
4 - 11 z: zzzzzzzzzkzqzzzzvnzz
9 - 10 r: rhrrrrrrrrrr
15 - 16 c: ccccccccccccccmwcc
2 - 4 g: wggz
3 - 4 g: jjgv
1 - 2 h: gthh
8 - 12 j: jjfjkjfjqqtjjkzvj
18 - 20 p: xbzbpvjqjbxfjdkgpwzp
9 - 14 t: ttttjtztttttwtj
2 - 4 l: lnlq
2 - 3 m: fpcbmzqkkfdzckl
1 - 3 z: zczslqzcztt
6 - 9 f: nbfvfvffsf
15 - 20 k: kkkkkkkkkkkskpkkkkkk
1 - 3 k: xkkqrskhkghqmkvtx
18 - 19 s: sssssssssssssvsssvh
10 - 11 x: fmxfvrxqzxnlx
4 - 15 r: xfphgnpwklmbmbtrkcbg
8 - 9 k: ktkkkkkjkk
4 - 8 m: vmmmmmmmmqmtm
8 - 13 r: rzqssbdrzxcmkhwv
2 - 4 k: kkddn
9 - 10 f: fffffwffjr
6 - 7 z: zdtczlzmz
1 - 3 c: cccc
12 - 13 r: rdqrrfrrrrrrzrrdrrr
2 - 14 k: kxwkkkdhkksxtkkkk
2 - 11 r: trrrnrmrrrrrrrtr
14 - 16 g: gggfgkgggggglcgsfggg
11 - 12 r: rrrrrrrrrrrq
13 - 18 l: lllllrlgllzllllmlgwl
2 - 4 g: lgvpg
4 - 5 p: kphkp
3 - 4 f: zfjf
3 - 4 x: wdxnjhnhdl
2 - 17 d: xbdddddwddddjdddd
9 - 12 f: ffffdffffffqff
4 - 8 k: bkzkkkkkm
2 - 4 s: hhfsztf
1 - 6 g: rjggggggggggggggq
3 - 7 l: gclpvpl
2 - 9 g: gcggggggwg
4 - 7 r: hnrlnrvjrrrrr
6 - 13 q: qpvgqqqqvqgvq
4 - 6 k: kkmsjk
12 - 13 n: nnknnnnnnnnkn
10 - 11 r: rrrrrrrrrrz
15 - 18 p: ppppppppdpxbpppxpw
5 - 8 j: jjfjjjxjd
14 - 16 v: vspvvvvbvvvdvwvvvv
3 - 9 m: jmsmmdmlmtmxcjm
12 - 14 z: kvzzzzzkzczzzjzzzzd
6 - 7 b: bbbbbbb
9 - 11 j: dbjcjjjjdvj
2 - 3 r: hmzb
7 - 8 h: hhhhkhkzhg
6 - 9 c: dcccjcccccfcc
4 - 16 x: qjxkmxnkmvlxlwvw
11 - 15 m: mmwmdmmmqzmmmmmm
1 - 3 g: ggfg
1 - 11 q: rqqnqfqqfqqqqqqbqqd
3 - 20 x: tsxslcxppwzngxztpfdx
9 - 10 r: rsqrjqzfrr
2 - 3 z: zkzjzzzzzrzzzzzz
11 - 13 l: llllllllllflll
13 - 14 v: vvvmvvvvvvqvrdvv
14 - 15 q: bqmqqqqqqmqqqrv
3 - 4 w: wjnmwsmwnwl
2 - 8 x: vxxsxxmxxxx
1 - 4 w: wdlwhmt
2 - 6 d: zzhdsdslj
4 - 6 f: xffffsfffsffqfc
5 - 12 m: mwdmwrmdpbmmm
1 - 2 x: nzbxx
7 - 11 n: pwnmppnzdhnnnljmcllw
2 - 10 g: dcpvqcbgzsqtv
3 - 4 k: fkhrkpw
2 - 4 k: bxkkkkkkk
4 - 7 c: bxzcmccxgc
5 - 6 q: jbvqsk
6 - 7 v: sqzmvvv
1 - 2 f: ffsffvcjt
10 - 17 m: mmmmmmzmmdmmmmrmmm
9 - 10 x: xxxxxxxgxnxx
4 - 8 w: wwwpwwqnwwwxwswwwwwv
14 - 15 n: nnnnnnnnnnnnnnf
2 - 4 w: wmws
5 - 13 f: ffffdvnffwffwfff
5 - 11 d: kjdrqdvdpxd
6 - 14 z: qqrkczzdjxxvmq
3 - 4 l: dlln
2 - 7 h: hhhhhhhhhhhh
4 - 6 d: fxdfdqqld
10 - 11 t: ttrjbstltrkttttttt
4 - 5 d: dddldd
2 - 3 x: xxcrgz
2 - 5 r: tskzvcrsnr
8 - 10 l: lpkjnkllwwklhbcl
1 - 2 c: ccccccccc
2 - 4 q: vqqwqqfqsqvd
3 - 10 n: nnnnkngngnqnfnnnc
1 - 5 g: jgggc
8 - 10 f: vxnlpftwxf
4 - 5 c: cfcnp
8 - 9 f: hfvkgwpffchpvdtkj
4 - 5 k: kkkkkk
3 - 14 m: rmdjmmdjrmkmlj
7 - 9 g: hgghzgbgxggmngbm
3 - 10 x: rsxgxxrwlh
7 - 11 g: ggwhgzgggpgggg
10 - 17 b: pdlbbbbbbnbbxtbfbb
10 - 13 j: bhvnjhvsvjfjjgp
10 - 12 v: vvvvvvvvvvvv
5 - 6 s: sswsltsk
9 - 10 c: jbccccchvcpxczcccz
10 - 11 j: mjjzxjmxjhsjjjjjjv
17 - 18 z: zzzzzzzzzzzzqzztzzzz
6 - 7 m: vdmmmdl
13 - 16 l: sllmlllllmflsklf
1 - 2 r: rrlr
1 - 3 w: twwxpkvpcwgdxbljpmw
16 - 18 x: xxxxxxxxxvxxxxxxxxx
14 - 16 b: bbbhbtbbbbbbbtbbbbb
1 - 2 q: gqlv
3 - 5 c: krhtc
7 - 12 j: jjjjjjfjrsjhjqlcd
4 - 7 r: krxzrrrrfrx
8 - 12 j: jfzbsjnmjjnlvrjhjk
2 - 6 d: wdmkzdvzmdjbcnpz
9 - 11 w: wlwwwwwwwwww
3 - 17 m: dzbnmqrxwmmbmdkdlmp
3 - 10 j: dzjjjjjjwljjjjjjjfj
10 - 14 z: mzzmzzzpntzznzwj
5 - 6 x: gxxztxbxhrzxx
4 - 10 t: wttttwwtttvbtpmc
6 - 13 s: szshssssssxsssss
9 - 10 k: skhbrmrfkk
7 - 13 f: fffffbfrwfffffffzf
10 - 12 x: qldpxxlxxxrxkxr
15 - 16 b: bbbbbbbbbbdbbbbl
9 - 11 b: bbbkbbbgbbngbbwbbb
7 - 8 m: mmmmmmmmmmrw
11 - 12 d: ddddddddddjd
3 - 6 t: tkqqthl
1 - 6 g: gwcgkg
18 - 19 f: ffffffffffffdfrffrtf
6 - 9 k: kkkkkvkkjk
2 - 4 p: ppbnkqpvtcmp
1 - 5 w: wptkw
3 - 5 c: ccqcc
12 - 13 r: hmrqbrsqnxqrrq
3 - 7 n: lrnvfxnzcnhzzblh
2 - 5 n: xnnpn
9 - 10 h: kvmdhnnkhhhhhdrhg
3 - 8 m: fzmmrnlmdfmmmp
3 - 5 d: hjxdl
2 - 4 l: lhcl
9 - 14 q: qqqrqqqqqqqqqbqgp
3 - 4 v: vtqvhv
16 - 18 g: ggggwggggggggggggvgg
2 - 3 w: wwmw
14 - 15 l: lllllllllllllnll
1 - 3 s: wsss
16 - 17 q: qqqqqqqqqqqqqqqqf
3 - 4 c: cccc
1 - 3 t: xttt
3 - 10 g: gjmgrvwcqlxmppkjz
1 - 3 l: xlllgll
1 - 4 q: gqjp
1 - 5 z: zzhztzz
11 - 12 v: vcvvvvvvvvmvvv
3 - 4 n: tnsdgnnm
3 - 4 q: qrjqqxbqqmlw
5 - 6 n: nnnznnnnnnnnnnnn
4 - 12 c: pmhcbcpcchdfjwcqgbcr
1 - 8 l: sqlnpclq
1 - 3 z: zczw
3 - 4 l: lllh
2 - 18 s: sssssscssssssssssgs
4 - 5 j: mljjj
5 - 6 q: qqffqqq
5 - 9 h: hhgfhhdhqcnhbswh
5 - 7 r: gbrrtrv
5 - 8 h: drdhhhbhr
13 - 14 p: ppppppppppppnbpppp
2 - 4 j: lpjbjjjtd
6 - 9 c: cccccqzcgc
3 - 10 w: wwlwwwwwwhwwww
11 - 13 s: wsssbsmssstsssssss
4 - 13 t: hgrglkhtqcxthrcj
9 - 13 c: bmccccczgccccw
1 - 7 z: zzzzzblz
4 - 5 p: hptvc
8 - 20 p: lnpfmrghqdptpjtvrqqf
5 - 8 m: rqskmvdmcqg
11 - 16 c: cqcccccnvcccccwcgc
4 - 6 f: vfggfsk
13 - 14 f: cwjgljbbntfhbp
3 - 4 c: ccccf
1 - 4 g: kggggg
7 - 8 j: ctlfgjmlr
1 - 3 t: sfgg
1 - 6 n: hnnnnnnn
9 - 18 v: vvvqvvpvfvvvmhvkpl
1 - 9 z: mzzzzzzzq
5 - 6 b: bbpbbb
1 - 4 m: cmmr
3 - 5 f: rfhqx
3 - 4 c: cccc
11 - 17 d: ddddddddsddkdddxddd
17 - 18 l: lllllllllllllllllq
10 - 11 f: fffffffffnqf
6 - 10 f: cfffffldnffffvf
10 - 14 d: sgddddnqxdgdtdxdrrmd
3 - 4 v: vvghv
6 - 11 g: ggtgfnqggvggwxgghg
4 - 5 l: llldm
3 - 9 t: pzstwtqnxtttttkt
13 - 14 z: zzzzzzzzzzzzzz
11 - 12 w: jrkdwwwlwxwl
5 - 10 r: hqkcrsprcr
9 - 11 n: nnnnnnnnnnnn
2 - 7 c: rcbgckj
9 - 10 k: sngvkckmtw
13 - 17 v: vhbvvvvvvvghvvvvb
7 - 8 t: tttgbcqt
8 - 9 v: vvvvvvvzsvvvvvv
15 - 16 j: jjjjjjjjjjjjjjjj
5 - 6 d: ddhdtshd
6 - 8 x: bdxxxxxxxpxmbxx
2 - 5 t: nxfwt
1 - 2 v: vvpv
6 - 7 r: rrwtrpr
1 - 3 t: tttttst
2 - 6 j: rpjrwhkq
9 - 11 m: mqkmlmpmmcm
4 - 5 n: vsxxknktfxnqm
5 - 10 v: rbvfvvsttvrgbvvj
1 - 9 g: ggdgggggkggg
1 - 3 k: kskk
17 - 19 p: ppppppphpppppmpppppp
2 - 8 m: kvqdbmjcwwf
1 - 2 r: rrhr
5 - 12 j: qjjgtjjhjjjjjj
10 - 11 m: mmmmmwmmmrmp
10 - 12 h: hhhhhhhhhhxhh
5 - 8 f: frtprsbf
2 - 4 k: fpqb
1 - 2 f: zfpf
4 - 5 p: ppppp
8 - 9 v: cqmzfrhvvbgxdvt
2 - 6 p: pszftm
4 - 5 z: zzzqz
2 - 3 l: lkkl
12 - 19 k: kkxzqfxmzklkssmsgkkv
4 - 7 h: hhmhhhpp
6 - 12 r: mrrrrrrrrrrrrrrrrrr
4 - 15 q: gvlbpbqxvnbjqvn
7 - 9 x: xxxxxxxnx
2 - 3 c: rcrcfwczgc
1 - 17 n: cnnnndnnnnnnnnnnznn
4 - 8 c: rcccwbccl
3 - 5 t: dltbt
10 - 13 r: rrrrrrdrrgrrqnr
3 - 5 r: qrhrprrrrrr
1 - 7 m: pmkrxrznld
8 - 16 b: bcmbnbbbbnzbbbbbfv
7 - 9 c: cmcmchscw
2 - 4 w: sfwwww
3 - 10 h: qhlhhhdmhhhc
7 - 8 b: dbbpbbqdj
2 - 5 l: zlpwlzqsg
12 - 15 m: mmmmdmmqmmmzmmf
5 - 8 t: ttttcttkt
15 - 16 m: lzmkmmmsmmmmmlmm
3 - 9 b: bbbbbbbbb
10 - 12 t: tttttttttjttlt
8 - 12 x: xxrxxxxxjxxxxxx
1 - 11 k: dbkkbzfqkkk
5 - 6 n: nnknztn
3 - 8 r: rnrpwqrdgxrhrrn
6 - 10 s: sfshcstppsrxvk
2 - 3 f: cffsrf
7 - 13 b: dcfggfbztwnbctvhvghf
1 - 7 z: zzzjzwdzz
5 - 8 k: kkkkwkkb
4 - 10 h: bkrbppchqhnqdl
8 - 11 g: ztjbgzggggg
1 - 3 j: jjxjjjjj
16 - 17 x: xxxxxxxxxxxxxxxxt
3 - 4 z: zzhz
2 - 4 b: jrrbmbjvb
7 - 9 s: sssssssss
3 - 10 g: pgxgpggcgtkrxw
13 - 15 x: xxvxmxxxxxxjxgtxtxxx
13 - 17 x: xxxxxxxxxxgxgxxxvxx
2 - 3 m: mwjmmm
16 - 17 f: fffffwfffffffffff
10 - 11 h: nqwxhtchhmhhhlhfhhh
3 - 5 m: mmnmrmmt
3 - 4 j: jzwjjpp
9 - 18 d: dddfbdjqdddsfddtwz
4 - 6 z: zzzzzxzzzzz
2 - 3 h: hndfh
9 - 10 h: hhthhhhhhgh
8 - 10 w: vptrwwwnwwn
5 - 9 d: jsvxdgndhk
18 - 19 p: pqwmsqhxzpdpqthkmnp
10 - 11 s: sshssssssbb
1 - 4 z: zzzzz
16 - 19 n: nntnmnnntbwdnxlmdtn
7 - 8 r: prqcxsrrt
6 - 9 k: kkkgkkkkkk
7 - 11 m: tbhqvmtzfxzb
7 - 8 x: mxxxxxxsjnxhjr
6 - 10 l: llnlllllcl
6 - 7 l: sljlfhl
1 - 5 n: dnntb
2 - 8 h: shzlhhvhxlwph
17 - 18 w: wwwwwwwwwwwwwwwjwv
5 - 12 d: ddddmddddddrd
6 - 9 k: fkxkrkkkw
3 - 5 z: gfkzz
15 - 16 j: jjjdjjjjjjjjjjjjj
7 - 17 d: ldwddddddddncdlxdd
6 - 12 g: qgxmdgmlqgkgc
1 - 10 w: zwwwwwwwwgw
1 - 4 z: zzzpv
2 - 9 k: kkpkkkkjdmkkkhm
4 - 12 g: gggmgggglgggzggggcg
8 - 11 z: zzzzzzsxzzzp
3 - 8 s: ssssbsmbpshssbhxsq
7 - 10 m: mmmmrmmmmcmkm
3 - 7 m: mmpmmmj
3 - 9 q: qvdqnxbqqm
3 - 10 f: ffbcwcfpkf
11 - 16 b: jvjbhvcnhhnbblbrmpbl
5 - 6 l: lbnrll
4 - 6 h: hhmhhmw
1 - 15 h: whhhhhhhchlclhthrhh
5 - 6 l: nlfllllpf
2 - 3 f: nvffq
15 - 20 l: llllllllllllllrllllz
7 - 9 z: zzzzzznzwz
1 - 6 m: mmmmmmm
6 - 7 v: ckvbtcv";

        public string skiSlopeTestData = @"..##.......
#...#...#..
.#....#..#.
..#.#...#.#
.#...##..#.
..#.##.....
.#.#.#....#
.#........#
#.##...#...
#...##....#
.#..#...#.#";

        public string skiSlope = @"...........#..#.#.###....#.....
...#..#...........#.#...#......
#.....#..#........#...#..##....
..#...##.#.....#.............#.
#.#..#......#.....#....#.......
.....#......#..#....#.....#....
.......#.#..............#......
.....#...#..........##...#.....
...#....#.#...#.#........#...#.
..#.........###.......##...##..
.#....#...........#........#..#
..#.............##.............
..#.##.#....#................#.
.....##.#.......#....#...#.....
......#.#....##................
..#..........###..#..#.#..#....
....#..............#....##..#.#
.#.........#.#....#.#.#....#...
..#.....#......##.#....#.......
..#.#....#..#.#...##....###....
...#......##...#........#.#..#.
.##.#.......##....#............
...##..#.#............#...#.#..
.##...##.#..#..................
..#......##......#......##.....
.....##...#..#...#.........#...
.##.#.....#..#..#.##....##....#
..#.#......#.......##..........
......................#......##
##.#...#.................#.#.#.
......#.#..........#.....##.#..
#.#......#.....#...........#...
.....#...#.......#..#..#.#...#.
...........#......#.#...#......
....##...##...........#......#.
.........#.##..................
......#...#....#......##.##...#
......#...#.#########......#...
.......#.#...#.......#..#......
............#...#...#.###...##.
...........#..........#...#....
...#..#.#................#.#..#
..#....#.....#.............#.#.
....##......#........#....#....
........##...............#....#
........#..#...#..............#
...#....#.#...#..#...#....#.#.#
.........#.......#....##.......
#.##..............#.#........##
......................###......
.........#....##..##....#.#.#..
.#...##.#.#...#....##..#.....#.
....................#.#......#.
.#..#.......................#..
..#..#.............#..#....#...
...#...#..#...#...#.#..#.##....
........#....#...#....#........
.#.....#........#.........#...#
...#......#..#..#..####..#.....
#....#..............#.##.......
.#....#.............##...#.....
....#...#.##........##......#..
##....#...#.......#..#........#
....##........................#
..................#..#.........
..#....#........#..#.......#...
#...#..#....#...##...........#.
.........#..#..#.#.##..........
....#.#..#.....#..#.#.#.#..#.##
##................#.##.....#...
.#.....###..#..#..#.....#....##
...#...........#..........####.
.#.....#....#......#.##..#.#...
..#...##....#................#.
........#.......#......#.#.....
....#.#.#.#....#...#......#..#.
...........#......#..#.........
###...##......##.#..#....##....
##....##.........#..#....###...
#.#.....#....#......#...#..##..
#....##.#..............#.##....
.#........#.#.........#...#....
......................#......#.
........#..#..##.....#..#.#....
..#...###.................#..#.
...#...#............#..........
.##.......#..#.........#....#..
.#..............#....#....##...
...............##..#.#.......##
.#.....#....#...#..#.......#..#
#..#.............#....#......#.
.....#.#......#.........###..#.
.#...#.#...............#....#..
#......#.............#.........
.#.##.#.####...#..#.##..#.....#
.....#......#..#...#.......#...
#........###...#.....#..#.....#
....#.#.....#...#..........#...
...#.#.......#.#......#..#.##..
..#..........#.#..#.......#.#..
#...#.#..............#...###.#.
...#..#...#............###.....
..#..#...#.#............#..#...
.###.#.....................#..#
....#....#..#.....##.##........
#....#....#.#..#.........#.....
.#.....##....#............##..#
#....#.#...#...#..#.#......#...
#.....##.....##.....##.#...##..
...##...#..#..####.#........#..
.........#...#......##..##..#..
..#.....###.#..#..####.#.......
.......#......#...#..##....#...
.#.....#.#.#..#....#...#..##...
..........#.#...#...#.#..#.....
....#.....#........#.....##..#.
..#.#.##.........#...##.....##.
.........#.##....#............#
............##.....#.......#.#.
......#.....#...#..#..###......
##.....#.......#...##.#....#...
...........##......#..##...#.#.
..#.#.#.#...#.......#....#...#.
#.............#.....#.#...###..
##....#.......#.....#..##.#....
...#.......#....#.........##...
......#.......#......##.##.....
..#......#...#.#........#......
....#.#....#.#.##......#.....#.
#......#.........#..#....#.....
........#..#....##.....#.......
#......##....#.##....#......#..
..#.......#............##.....#
...........#...#...........#...
#.......#...#....#....#...#.#.#
..###..#........#........#.....
..#..###...........#.#......#..
.#...........#......#..........
.#.......#.....#.......#.......
..#......##.#............#....#
#..........#.....#.#..#........
.....#...##.##.......#......#..
..........#.....#........#.#.#.
....#......#.....#......#.#....
.........#.#.#..#...##....#...#
.........#.......#...##...#.#..
.##........#...............#...
.......#....#...........##.....
.........###......#.........#.#
......#.......#...#..........#.
...#.#..........##......#...#..
#.......#.#..........#.........
................#..#......#..##
.....#...#....#.#.....#........
#.....#....#...........#....#..
#....#.#..#...##....#...##.#...
...#.....#......#.#....#..#..#.
..#................#...#.#..##.
..........#..............#..#.#
.....##.....#..#.###...........
....#.#......#.#...........#...
.#....#.#.........##.#....#....
.#.#........#........###....#..
##.#................#...#..#...
.......#......##..#.....#..#.#.
...#............#......###...##
#.#...........#.........#......
.....#.#.#.................#...
....#..............#...#.#.....
...#.#.....##..#...............
.#..##...#....##.....###..#....
...............#...#...#.#.###.
.###....#.....#...#.#......#...
...#..#.....#.......#..##.#....
...........#..#....##..#...#...
...#...#..........#.......##.#.
............#.#.......#........
....#.........#.....#..........
...#.###.##..#...##..####..#..#
.#.#...#..#...................#
.....#..#.....##..#............
....#......#...##..#.##........
...#...............#..#.....##.
...#......#.........#.#..##....
.#....#.##.......#......#......
....#.......#....#..........#..
#.#.#....###.#.#.............#.
..##..###........#.#..#.#..#...
......#.#............##.#...###
.........#.#....#####.....##...
............##......#.#..#.....
...#.....#.....###....#........
##..........####.##.#.#........
....................##.....##.#
#.#............#........#......
....#...##.....#......#....#...
...###.#..##..................#
..###......#..............#.#.#
.#...#...........#....#........
....#............#..#..#.#.....
...#.........#.#.........#.####
..#...#...#...#...........#....
...............#.#......##..#..
#....#.#.......#.#..#......#..#
........#.#....#..#...#..#...#.
...#..#.......#...........#....
...........#.......#...........
.#......#................#.....
....#.#.#...#......#..#...#....
................#.#.#....#.....
.........................##..#.
.#...........#............##...
#...............#.....##.#.#..#
.........#.......###....#.....#
....##...#...#.....#..#........
........#.....#..#.#.#...#..#..
......#.......#.#.........#.#..
#......#............#...#....#.
#..##...#..#................#..
.##...#...#.....#.##.......#..#
.......#.##........##..##......
##.#..##...............#.....#.
......#....#..##...#......###.#
#........##..#....#.#......#...
.#......##.#...#.#...#.........
.#.#...#..#.............#......
.##..........#..........#......
.#.....#.....#..............#.#
..#.........#..#.#.....#.#....#
..#.##..............##...#..###
....................#..........
......###..#..#...........#....
..#..........#.......#...#.....
...#......#......#.............
....##..............#.#.....#..
........#.#......#..#........##
.............#...#.#.........##
...###...#..........##.......#.
.#..........#...##..#.#.....#..
##...#.........#...............
......#....#....#.....#.....#..
..........#....#...#...#..#...#
...##....#.#.#..#...##.........
#......#.#...##.###...#....#...
##.......##.#......##..#...#...
......#.............#.##.....##
#.......###....####.#...##....#
..#...#..#.......#..........#..
#.....#..#..#..#.##...###...#..
.....##.#..#..#..#.#....#...#..
..#...#..................##....
....#.#........##..............
#...#.......##...#...#.#.......
..#...#........##....#.#.......
..........###...###...#......#.
#.....#..###...##...##..#..#..#
..#.....##.....#.......##..#.#.
........#........#.........#...
.................#....#.......#
.......#...#.....#...#.#.......
....##...............#...##...#
.##...#................#...#...
.............#.................
.#..#....#....#.#....#.........
.#.#..#..........#.......#.....
.....##.....##...#..#..........
#...#.#.........#......#..#....
........#....#...#....#.#.##...
....#..#........#...#...#......
.#..#.....#.#...#.........#....
.#..#..#...........#..#....#...
....###.............#..#.......
#......#..#..##..........#.#...
#..#..#.##..#...#.#.#..........
....###......#.##.....#....#...
.##..#...#......##.#...........
..#..#.......#.....#.##....#.#.
.......#.#.#........#....##....
..##...#....#...............###
#..##..#...........#.#....##...
...##..#.....................#.
###......#....#....###..#...##.
.........##............#..#...#
..#..........#...#.#.#......#.#
.......#.....##..##......#.##..
#..........#.....##.#..........
#.......#.#...#...#....#.......
#...#.....##.......#.#..#.#.#..
.........#.#.#..#..#...#.###...
.................##...#....#...
###.......#..........##...#....
#.#..#.........#....##.#.......
......#.#.....#........#.......
.......#.#........#......#.#..#
..............#..#...##....#..#
#...........#...##.....#..#.#..
..#....#..#.#.#...#..#....#.#..
...##.#.....#..#...##..#.....#.
..#.#................#........#
......#...#.............#......
.##............#....#...#..#...
....#...#...........#.......#..
.###..#.......#.............#.#
.#.#....#.#...........#.#......
...#.........#.........#..#....
...#..........#.#.....#.#......
.....#........#....##......#...
..#.#.#......#..#.#......#....#
.#.#..#................#.#.....
.#.#.........##...#.......#.#.#
#..#.....#...#..#...........#..
..##......####......#..#....###
#.....###....#.#........#..#..#
..##.#...#.#..##..........#..#.
#.........#.#.............#...#
...#.#...#...#.#.#....##.......
##.##...#.....#...#...........#
....#........#.#.....#.........
.................##..#..##...##
.....##....#...#...#.....#..#..
....#...#........#............#
..#...........##....#...#...##.
.....#......#.........#..##.#..";

        public string passports = @"byr:1971
eyr:2039
hgt:172in pid:170cm hcl:17106b iyr:2012 ecl:gry
cid:339

hgt:161cm eyr:2027
ecl:grn iyr:2011 hcl:#a97842 byr:1977 pid:910468396

cid:257
ecl:gry hgt:186cm iyr:2012
byr:1941
eyr:2029
pid:108935675
hcl:#cfa07d

hgt:165in
hcl:#cfa07d eyr:2035 pid:82570731
byr:1973
cid:74 ecl:xry

eyr:2020 cid:105 iyr:2012 pid:947726115
hcl:#ceb3a1 ecl:grn byr:1966 hgt:151cm

hcl:#888785 eyr:2027 ecl:hzl byr:1966
pid:853607760
iyr:2012
hgt:155cm

hgt:61cm
iyr:2019
byr:1952 pid:#1468e6 eyr:2033 ecl:#7d39d5 hcl:z

pid:2306523501
eyr:2032 hcl:z ecl:brn
cid:266 hgt:151in iyr:2024
byr:2008

hcl:#a97842 hgt:191cm eyr:2025 ecl:gry byr:1923 pid:574171850 iyr:2019

hgt:140
iyr:1987 byr:2003
eyr:2013 cid:242 hcl:z
ecl:#19177c pid:150cm

byr:1959
hgt:169cm hcl:#7d3b0c ecl:gry eyr:2028 cid:107 pid:584790749

byr:1955
cid:309
hcl:#a97842
pid:740105085 iyr:2020
hgt:188cm ecl:oth eyr:2029

iyr:2016 hcl:#cfa07d eyr:2026
hgt:151cm
pid:394185014 ecl:grn byr:1974

pid:226566060 ecl:blu cid:272 hgt:188cm hcl:#efcc98
eyr:2029 iyr:2014
byr:1956

pid:#7c7a9d ecl:#8fa327
eyr:2006 iyr:2022
hcl:#7d3b0c hgt:169
byr:2025

hgt:188in byr:2015 ecl:xry
iyr:1975
eyr:1928
pid:8939875193 hcl:7bbcce

hgt:193cm
eyr:2029
pid:141707808 byr:1997
cid:83 iyr:2019
ecl:hzl hcl:#cfa07d

iyr:2019
pid:681586971
hcl:#6b5442 hgt:165cm
eyr:2022 ecl:brn byr:1985

byr:1970
iyr:2016 hgt:156in pid:#e32394 eyr:2024
hcl:#efcc98 ecl:grt

iyr:2013
ecl:grn pid:341584587 eyr:2027 hgt:185cm hcl:#18171d
byr:1935
cid:113

hcl:#fffffd ecl:grn iyr:2010
pid:738986504 hgt:98 eyr:2024
byr:1968

pid:175337478 ecl:oth hgt:173cm hcl:#733820
eyr:2025 byr:1960
cid:283 iyr:2018

byr:1959
hcl:#341e13 eyr:2023
pid:566612260 hgt:176cm
iyr:2017 ecl:grn

cid:321 pid:355095309 byr:1945
hgt:161cm
eyr:2029 iyr:2017
ecl:brn hcl:#733820

hcl:#c0946f pid:75316487 iyr:2013 cid:201 hgt:152cm ecl:lzr byr:1996 eyr:1928

hgt:160cm iyr:2010 hcl:#a018b9
eyr:2024 ecl:amb
cid:347

eyr:2021
pid:893047101 iyr:2016 ecl:hzl hcl:#866857 byr:1988
hgt:166cm

hcl:#7d3b0c
ecl:blu pid:085336099 eyr:2024
iyr:2019 hgt:178cm byr:1999

ecl:grt iyr:2022
hcl:z
hgt:192cm byr:2010

pid:677187953 eyr:2025 iyr:2020 hgt:163cm byr:1957 ecl:grn hcl:#cfa07d

cid:213
byr:1987
pid:113078018 ecl:blu iyr:2013 eyr:2022
hcl:#7d3b0c hgt:157cm

ecl:blu hcl:#c0946f hgt:186cm
byr:1992 eyr:2028 iyr:2010

pid:#b01156 hgt:67
byr:2014 ecl:#35dca0 eyr:1922 hcl:790130

hcl:#602927
ecl:blu hgt:173cm byr:1974 pid:116377061 cid:294 eyr:2030 iyr:2010

hgt:151cm eyr:2022 iyr:2011 ecl:blu byr:1987 hcl:#733820
pid:#b90d2e

cid:188
byr:1990
hcl:#602927 iyr:2026
pid:530373696
hgt:154cm ecl:gry
eyr:2029

hgt:178cm eyr:2027
hcl:#733820
ecl:grn iyr:2014 pid:575371227 byr:1965

hcl:#fffffd iyr:2020
hgt:185cm ecl:amb pid:692760311
byr:1961

byr:1967 pid:397518948 ecl:lzr iyr:2015 hcl:#cfa07d cid:328
hgt:177cm eyr:2035

hcl:#8e1608
pid:554618249 iyr:2010 hgt:176cm cid:220
ecl:brn byr:1928 eyr:2029

eyr:2030
ecl:oth cid:177 hcl:#602927
iyr:2010 hgt:66in
pid:915661465 byr:1992

ecl:brn pid:558826437 hgt:151cm byr:1936 hcl:#fffffd
eyr:2021 iyr:2012

eyr:2033
iyr:2019 hgt:190cm byr:1953
hcl:#6b5442
pid:584941735 ecl:hzl

hgt:71cm
byr:2015 iyr:2025
ecl:#663b65 eyr:2039 hcl:z pid:62548949

ecl:hzl byr:1943
iyr:2020 hgt:175cm pid:830628564 hcl:#7d3b0c eyr:2021

hgt:182cm byr:1951 cid:175 eyr:2021 pid:635966127 ecl:blu iyr:2014 hcl:#18171d

hcl:#733820 iyr:2011 pid:581100835 eyr:2022 ecl:grn byr:1985 hgt:192cm

iyr:2013
ecl:grn
hgt:185cm hcl:#a97842 byr:1981 eyr:2029 pid:711625030

byr:1995
pid:326992839
iyr:2015
eyr:2028 hcl:#733820 ecl:hzl

hgt:160
eyr:2037 ecl:#6b6b83
cid:123 iyr:2028
pid:7692333345
hcl:z byr:2029

hcl:#6b5442 iyr:2030
hgt:165cm byr:2028 ecl:#21516d
eyr:2039
pid:182cm

hgt:159cm iyr:2018 pid:610521467 eyr:2028 ecl:amb byr:1934 hcl:#602927

ecl:blu
hcl:#09d9a5 hgt:162cm iyr:2020
eyr:2025 byr:1971 pid:406714780

hgt:179cm eyr:2022 hcl:#18171d
ecl:blu pid:314891131 iyr:2015
byr:2002

hcl:#623a2f hgt:181cm pid:442693333 byr:1990 ecl:grn eyr:2027
iyr:2011

iyr:2022 eyr:1939
pid:557187110 hcl:#18171d hgt:60cm ecl:#d6ac04 byr:1984

ecl:grn byr:1948 hgt:174cm pid:438876745 cid:321
iyr:2018
hcl:#866857 eyr:2023

hgt:189cm iyr:2012 hcl:#602927 pid:978388052 ecl:brn
eyr:2030

ecl:amb cid:235
byr:1938
pid:315825546 hcl:#ceb3a1 eyr:2029
iyr:2013 hgt:171cm

ecl:dne hcl:z
hgt:76cm byr:2010
cid:185 eyr:2001

hcl:#733820 byr:1988 pid:558453117
hgt:66in
ecl:oth iyr:2010 eyr:2021

byr:1926 pid:796557821 cid:155 hcl:#efcc98
hgt:159cm eyr:2023 ecl:oth iyr:2016

byr:2023 eyr:2031 hcl:0ba99a pid:14902250
hgt:132 ecl:#9b89b1 iyr:2017

hcl:#a97842 byr:1926
cid:205
ecl:blu
iyr:2016 hgt:159cm eyr:2029

byr:1939 hcl:#866857
pid:025607627 hgt:174cm cid:309 eyr:2026 ecl:brn

ecl:hzl pid:805133506
iyr:2014
byr:1991
hcl:#cfa07d
cid:350
hgt:190cm

hgt:155cm byr:1941 eyr:2024
cid:164 hcl:#602927 iyr:2013 pid:531781358 ecl:amb

hcl:#72a068 hgt:164cm
pid:621006770
ecl:brn
eyr:2029 byr:1969

byr:1991
ecl:grn iyr:2020
pid:9921729009 eyr:2029 hcl:#623a2f
hgt:62in

iyr:2017 ecl:hzl
pid:768217275 eyr:2020 byr:1937
hcl:#866857 hgt:157cm

cid:270 byr:1993 hcl:#733820 ecl:hzl pid:722650020
hgt:174cm iyr:2010
eyr:2021

hcl:#c0946f ecl:blu
hgt:154cm
eyr:2022 byr:1929 pid:357023679 iyr:2010

ecl:hzl
iyr:2013 hgt:165cm byr:1979 eyr:2023 hcl:#733820 pid:008734536

hcl:#341e13
eyr:2030 byr:1993
iyr:2014 hgt:193cm
cid:346
ecl:blu pid:536339538

eyr:2030
ecl:hzl
cid:296 pid:660062554 hcl:#efcc98
byr:1977 hgt:179cm
iyr:2010

cid:119 pid:498520651 hgt:159cm
eyr:2029 iyr:2015 hcl:#18171d
ecl:gmt
byr:1950

eyr:2025 iyr:2010 hcl:#efcc98 pid:196372989 hgt:181cm byr:1952 ecl:oth

cid:317
eyr:2026 ecl:blu hcl:#733820
hgt:184cm
pid:549730813 byr:1927 iyr:2018

pid:591769824
hgt:180cm
byr:1920
ecl:blu
eyr:2021 hcl:#cfa07d iyr:2017

pid:988946348 hgt:183cm cid:117 byr:1955 ecl:blu
iyr:2015 hcl:#623a2f eyr:2029

iyr:2014
eyr:2026 hgt:184cm
ecl:oth
hcl:#7d3b0c pid:252101860

byr:1995
hgt:182cm ecl:brn hcl:#6b5442
iyr:2012 eyr:2028 pid:482757872

iyr:2017 cid:333 ecl:gry hcl:#623a2f hgt:157cm eyr:2021
pid:487895819
byr:1951

hcl:#fffffd
hgt:193cm eyr:2025 byr:1927 iyr:2014 ecl:oth pid:989206297

eyr:2030 ecl:brn hcl:#18171d hgt:193cm
iyr:2013 byr:1953 pid:862636088

hcl:#fffffd
pid:204286737 ecl:gry byr:1923
hgt:181cm
iyr:2015
eyr:2023

cid:288 pid:413935643 ecl:gry
iyr:2012
hgt:171cm
hcl:#623a2f
eyr:2020 byr:1943

byr:2023 hcl:#c0946f
ecl:oth
pid:182634296 eyr:2009
cid:306 hgt:183cm
iyr:2029

eyr:2026 ecl:hzl byr:2003
iyr:2027 pid:734296691 hgt:188cm hcl:#fffffd

hcl:#18171d ecl:gry pid:401957684 eyr:2020
iyr:2017 cid:141 byr:1944 hgt:74in

ecl:grn hcl:z
pid:335097003 byr:1925
hgt:170in iyr:2020 eyr:2022

pid:727198487
hgt:173cm
cid:323 hcl:#18171d iyr:2012 eyr:2024
byr:1995 ecl:blu

ecl:amb hcl:#602927
pid:460274414
hgt:76in byr:1995
iyr:2020
eyr:2028

byr:2002 ecl:oth pid:101164770
hgt:172cm hcl:#fffffd eyr:2023 iyr:2016

ecl:blu hcl:#888785 iyr:2016 pid:031162631 eyr:2025 hgt:186cm
byr:1959

ecl:blu pid:093242619 hgt:188cm byr:1970
eyr:2025
hcl:#6b5442
iyr:2020

byr:1990 eyr:2025 ecl:grn
pid:907309460
iyr:2011 hcl:#602927 hgt:62in

pid:346468647 eyr:2021
ecl:oth hgt:169cm
iyr:2010 cid:233
hcl:#b6652a byr:1977

pid:904834317 iyr:2011
hcl:#b6652a eyr:2028 cid:281
byr:1944 hgt:187cm ecl:gry

eyr:1988 pid:663941602
hgt:156in
hcl:#fa2e93 iyr:2015 ecl:gry byr:1953

hgt:184cm cid:107 pid:094829817
ecl:gry byr:1998 eyr:2023 iyr:2017

eyr:2020 ecl:gry byr:1955 hcl:#a97842 pid:553841536

hgt:185cm eyr:2022 hcl:#341e13 ecl:oth byr:1934 pid:863541754 cid:178
iyr:2016

eyr:2029 iyr:2014 byr:1937 cid:232 hgt:177cm hcl:#fffffd ecl:blu
pid:076753558

hcl:#cfa07d
hgt:168cm
ecl:grn
pid:664159349 eyr:2028 iyr:2017 byr:1972

hcl:#a97842
byr:1987
eyr:2020 hgt:182cm
iyr:2018
ecl:brn pid:560272731

hgt:172cm cid:125 ecl:blu pid:291640184
byr:1926
iyr:2014 hcl:#ceb3a1

iyr:2027 hgt:84 hcl:z
ecl:#b68fec
pid:809408661
byr:2018 eyr:1927 cid:87

pid:951007276 cid:260 eyr:2025
ecl:brn iyr:2015 byr:1957
hcl:#4b8216 hgt:161cm

pid:359973697 hcl:#6b5442
eyr:2022 hgt:169cm
byr:1965 ecl:brn iyr:2013

iyr:2012 hgt:65in eyr:2024 pid:842371195
ecl:amb
hcl:#341e13 byr:2000

ecl:hzl hgt:170cm byr:1950
cid:289 eyr:2037 iyr:2021 hcl:#18171d pid:389051819

hgt:159cm
ecl:amb hcl:#c0946f eyr:2020 pid:010539976 iyr:2011 byr:1921

hgt:176cm cid:270 pid:838338992
eyr:2024 hcl:#866857
ecl:amb iyr:2015 byr:1982

ecl:blu
cid:246 hgt:185cm
byr:1987
hcl:#fffffd pid:042361456 eyr:2022
iyr:2010

hgt:164cm
pid:881486702 ecl:brn byr:1969 hcl:#c0946f
iyr:2010 eyr:2030

iyr:2019 hcl:#6b5442 hgt:167cm
ecl:amb
cid:207 byr:1922
eyr:2025 pid:343956182

ecl:oth iyr:2012
hgt:158cm
eyr:2024 hcl:#602927 byr:1964

byr:1988 pid:030965463 hgt:154cm
ecl:gry eyr:2020 cid:227
iyr:2012
hcl:#3edc53

hgt:178cm hcl:#c0946f byr:1945 ecl:amb eyr:2030

hgt:158cm pid:270264980 eyr:2027 iyr:2016 byr:1928 cid:259
ecl:gry hcl:#733820

byr:2026 hgt:164in cid:235 ecl:xry
hcl:z pid:2517730699
eyr:2033 iyr:2024

ecl:grn hgt:69cm pid:1321222581 byr:1987
eyr:2035
iyr:2018 hcl:#fffffd

hcl:#733820 cid:244
ecl:gry iyr:2013 eyr:2028
pid:794178180 hgt:74in byr:1923

hcl:#a97842 byr:1934 ecl:hzl eyr:2027
pid:401882857
iyr:2018 hgt:185cm

iyr:2018
pid:665564950 byr:1990 ecl:hzl
hgt:154cm
eyr:2026 hcl:#623a2f

hcl:#602927 cid:189 byr:1967 pid:332861702 eyr:2021
hgt:163cm
ecl:amb

ecl:grn pid:734161280 hgt:184cm
iyr:2018 eyr:2020 byr:1929 hcl:#a97842

iyr:2018 byr:1925
eyr:2022 hgt:193cm ecl:hzl
hcl:#341e13
pid:008582320

byr:2025 ecl:dne hgt:167cm pid:48963526
iyr:2025 hcl:z
eyr:2034

hcl:#cfa07d ecl:hzl eyr:2029 cid:194 byr:1936
iyr:2020
hgt:186cm
pid:328573727

iyr:2011 hgt:188cm pid:338435675 cid:326 ecl:gry
eyr:2027
hcl:#6b5442
byr:1958

pid:165cm
hgt:70 iyr:1996
eyr:2034 cid:210 hcl:z ecl:#75606f byr:2027

hgt:180in hcl:#a0515a pid:#97a753
byr:2026 iyr:2016
eyr:1995

eyr:2020
hcl:#18171d byr:1978 iyr:2012 hgt:68in
ecl:amb cid:346 pid:332495922

ecl:blu hgt:61in pid:747650669
byr:1961 eyr:2028
iyr:2020
hcl:#4992f2

byr:1958 iyr:2017 ecl:oth
hgt:153cm
hcl:#602927 eyr:2023 pid:108391213

byr:1976 eyr:2023 iyr:2015 hgt:177cm pid:391628371 hcl:#8069c4
ecl:grn

pid:910402636 ecl:gry hgt:188cm byr:1924 hcl:#82dfdc eyr:2029

byr:1978 pid:302223240 iyr:2017
hgt:174cm
hcl:#6b6569 ecl:blu eyr:2027

cid:135
byr:1995 iyr:2015 ecl:oth pid:054611703
eyr:2023
hcl:#7d3b0c hgt:75in

ecl:grn
eyr:2020 hgt:184cm pid:444944678 iyr:2019 hcl:#efcc98

byr:1946
hgt:70in eyr:2022 hcl:#6b5442 ecl:amb iyr:2018 pid:859762925

byr:1995 eyr:2022
ecl:grn pid:575081777
hcl:#341e13
hgt:183in iyr:2018

eyr:2028 hgt:162cm byr:1989 hcl:#0bd11f
iyr:2020 ecl:gry
pid:073498924

iyr:2014
pid:122787281 byr:1982 cid:138 eyr:2021 hcl:#866857 ecl:hzl hgt:184cm

cid:198 byr:2014
pid:5529128129
hgt:185in
iyr:2025
hcl:z
eyr:2023
ecl:gmt

eyr:2021 hgt:170cm
cid:74
iyr:2019 pid:943445928 byr:1980
ecl:oth hcl:#ceb3a1

iyr:2020 eyr:2030 pid:201122734 cid:246 hgt:169cm ecl:grn hcl:#fffffd byr:1962

pid:025560194
byr:1989
hcl:#cfa07d hgt:182cm ecl:blu eyr:2025 iyr:2012

hgt:151cm
hcl:#efcc98 ecl:blu
byr:1983 eyr:2023 pid:814513328 iyr:2013 cid:73

byr:1961 pid:536384108 hgt:188cm ecl:amb iyr:2013 eyr:2027 hcl:#888785 cid:121

pid:364607819
eyr:2024 ecl:amb hcl:#b6652a iyr:2016
byr:2000 hgt:187cm

hcl:z eyr:1956 iyr:2028
hgt:168cm cid:105
byr:2026
ecl:#5b17d3

cid:207 pid:913509058 ecl:brn byr:2001 eyr:2026
hcl:#866857 iyr:2019
hgt:180cm

pid:363979129
eyr:2027 iyr:2013
ecl:gry hcl:#866857 byr:1957 hgt:62in

byr:1932
eyr:2027
hgt:66in ecl:hzl hcl:#efcc98 pid:417620217 iyr:2013

iyr:2013 cid:331 hgt:192cm
hcl:#d896d9 pid:795744816 byr:1935

byr:1960 hcl:#888785 hgt:176cm ecl:hzl pid:025206542
iyr:2015 eyr:2030

ecl:oth hgt:182cm
hcl:#341e13
pid:526568190 iyr:2018 cid:280 byr:1997
eyr:2028

hgt:186cm pid:273625601 byr:1993 iyr:2018 eyr:2021 hcl:#733820
ecl:blu

hgt:74cm
byr:1981 eyr:2024
ecl:amb iyr:2012 pid:154027492 hcl:#733820

hcl:#a97842 pid:347084450 ecl:oth
eyr:2030 hgt:176cm byr:1955 cid:229
iyr:2013

hcl:#fffffd byr:1979 iyr:2017
pid:183840860 hgt:177cm ecl:blu eyr:2023

pid:045246162 eyr:2021 byr:1928 hgt:190cm ecl:gry hcl:#602927

pid:273620987
eyr:2022 hgt:162cm
cid:269
byr:1991 hcl:#602927 ecl:amb iyr:2019

pid:621069556 ecl:amb
cid:202 byr:2020 hgt:189cm
iyr:2014 hcl:#fffffd
eyr:2027

eyr:2022 byr:1988
hgt:190cm
pid:349839553 hcl:#602927 iyr:2018 ecl:gry

iyr:2014 ecl:gry
hcl:#733820 eyr:2025 hgt:179cm pid:231854667 byr:1984
cid:102

eyr:2020
pid:509400891 hcl:#cfa07d hgt:172cm
ecl:grn byr:1997 iyr:2020

iyr:2017 byr:1994 hgt:174cm ecl:amb
pid:685743124
hcl:#fffffd eyr:2029

iyr:2012 hgt:177cm byr:1999 pid:549190825 hcl:#b6652a eyr:2028 ecl:oth cid:316

hgt:192cm ecl:grn byr:1924
iyr:2011 eyr:2029 hcl:#efcc98
pid:215962187

iyr:2011 hcl:#866857
cid:164
hgt:184cm
ecl:gry eyr:2023 byr:1959 pid:204093118

hgt:172cm ecl:hzl hcl:#3f2f3a pid:623470811 byr:1938 iyr:2013 eyr:2022

hcl:#b6652a
iyr:2019 hgt:152in
ecl:oth
pid:189008850 byr:2006

ecl:oth hcl:#602927
pid:049746898 byr:1924 hgt:150cm eyr:2026
iyr:2014

ecl:oth
eyr:2028 byr:2018 hcl:#733820
pid:8676207205 iyr:2018
hgt:190cm

eyr:2023 cid:308 hgt:170cm ecl:oth iyr:2014 hcl:#18171d pid:874405208 byr:1936

eyr:2021 ecl:hzl
pid:423603306
hcl:#c0946f cid:147
byr:1988 iyr:2016 hgt:164cm

hgt:176cm iyr:2010
hcl:#6b5442 cid:280 byr:1988 ecl:hzl pid:967151288 eyr:2028

cid:299 hgt:163cm ecl:gry
pid:561439154 eyr:2023
hcl:#cfa07d iyr:2019 byr:1959

pid:635547007
ecl:blu
byr:1996 hcl:#7d3b0c cid:280 eyr:2023
hgt:170cm iyr:2017

hcl:#888785 iyr:2014
ecl:brn
hgt:190cm byr:1941 eyr:2021

hcl:#c0946f cid:199 hgt:162cm ecl:amb pid:130696599 eyr:2022 iyr:2018 byr:1948

cid:314 hcl:#a4fc09 ecl:hzl iyr:2019
pid:886849824 eyr:2026 byr:1933 hgt:178cm

byr:1996 iyr:2016 eyr:2030 hgt:169cm
pid:119207760
hcl:#ef542c
ecl:brn

iyr:2030 eyr:2039 hcl:#c0946f pid:#7336a0 hgt:182cm cid:347
ecl:#c81361 byr:2003

pid:727812879 iyr:2013 eyr:2027 hgt:172cm
hcl:#7d3b0c ecl:gry byr:1966

hcl:#341e13
iyr:2016 pid:744997238
cid:322
byr:1973
ecl:hzl eyr:2028 hgt:190cm

hgt:171cm eyr:2026
iyr:2014 ecl:oth
pid:074049558 hcl:#04083f byr:1923

pid:973713235
eyr:2021
ecl:brn
byr:1922 hcl:#fffffd iyr:2012
hgt:178cm

ecl:#10165d
cid:201 eyr:2026 pid:#ceefa8 byr:2020
hgt:164cm iyr:2011
hcl:9fccf7

ecl:blu
hgt:165cm iyr:2012 eyr:2025 pid:775787557
byr:1952 hcl:#623a2f

pid:6186829005 ecl:lzr hcl:z hgt:69in iyr:2021 byr:2018 eyr:1974

pid:824641755 eyr:2028 byr:1950 hgt:184cm
hcl:#c0946f
iyr:2014

hcl:#7d3b0c cid:84 hgt:187cm iyr:2015
pid:895876610
byr:1988 eyr:2023

hcl:#fffffd
hgt:157cm iyr:2020 eyr:2030 ecl:grn pid:486236241

iyr:2010
eyr:2029
hgt:74in ecl:hzl byr:1926 pid:348573885 hcl:#9d1214

hgt:171cm ecl:oth
eyr:2022 pid:148728436 byr:1993 hcl:#a97842 iyr:2013

iyr:2019
hgt:151cm
eyr:2020 pid:319882814 ecl:grn byr:1966 cid:256 hcl:#3107b3

hgt:184cm ecl:grn
byr:1947
eyr:2025 iyr:2015 pid:827962962 cid:62 hcl:#f3a364

iyr:2013
hcl:#fffffd pid:215012801 ecl:amb eyr:2024
hgt:154cm
byr:1973

ecl:hzl hgt:152cm
hcl:#623a2f
byr:1944 eyr:2022 pid:295632731
cid:243 iyr:2019

ecl:brn
iyr:2011 pid:089250747 byr:1984 hcl:73e739 cid:253 hgt:161cm eyr:2021

hcl:#18171d byr:1944 pid:732054667 eyr:2021
ecl:oth hgt:173cm

ecl:gry pid:445116331
hcl:#a97842
hgt:187cm eyr:2026 iyr:2020 byr:1992

hcl:80c091 pid:745555899
iyr:2021
hgt:170cm
byr:1990

pid:058987865 byr:1927 cid:209
hcl:#65ccf6 eyr:2025
ecl:brn iyr:2012 hgt:164cm

hgt:67cm
byr:2026 hcl:f8e749 iyr:2023 eyr:1921 ecl:lzr

eyr:2028 iyr:2013 pid:103268377 hgt:179cm byr:1922
ecl:hzl
hcl:#7d3b0c

byr:1923 ecl:gry hgt:167cm hcl:#7fc8ee iyr:2015 pid:427963077 eyr:2024

byr:1927 ecl:grn pid:741328150
eyr:2029 hcl:#733820
iyr:2015 hgt:157cm

hgt:70cm hcl:e76970 iyr:1945 cid:186
byr:1921 eyr:2029
pid:823622634
ecl:zzz

hgt:61cm cid:87 hcl:d5e5ff
eyr:2024 ecl:dne pid:182634269
iyr:2029

hcl:#623a2f eyr:2020 byr:1936 ecl:gry pid:236984204
iyr:2011 hgt:156cm

pid:872645776
byr:2023
cid:220 ecl:blu hgt:172cm eyr:2033
iyr:2010 hcl:ff82f9

pid:774489073 iyr:2013 byr:1922 ecl:brn eyr:2025 hcl:#18171d hgt:163cm

eyr:2024 hgt:65in byr:1962 iyr:2019
pid:112233558 hcl:#888785 ecl:grn

hgt:172cm eyr:2022
hcl:#18171d ecl:blu
pid:609008608 iyr:2013
cid:244 byr:1980

cid:124 hgt:175in eyr:2025
hcl:674e80 pid:099875931 iyr:1956

byr:1926 hgt:188cm
ecl:hzl eyr:2021
iyr:2018
hcl:#866857 pid:557800355

byr:1939 pid:200409089
eyr:2026 hgt:164cm
ecl:grn iyr:2013
hcl:#733820

cid:73 hgt:169cm iyr:2016 byr:1976 ecl:gry eyr:2024
pid:043453462

pid:609818712 hcl:#733820 byr:1958
eyr:2025 hgt:187cm iyr:2017 ecl:gry

hgt:66in pid:618590610 iyr:2013 byr:1938 hcl:#d1bda9
eyr:2022
ecl:grn cid:69

hgt:156cm pid:755742405
byr:1929 hcl:#6b5442 eyr:2024
iyr:2018
ecl:gry
cid:105

eyr:2030 pid:77022842
hgt:160cm byr:1989
iyr:2011 hcl:#7d3b0c ecl:blu

iyr:2015
hcl:#341e13 byr:1968 pid:434159843
ecl:amb hgt:150cm
eyr:2030

hcl:z eyr:1993 pid:#b3a5a6 iyr:1947 hgt:176in
ecl:#78876d

cid:249 hcl:#cfa07d
hgt:180cm ecl:gry eyr:2026 byr:1965
pid:048327438 iyr:2010

pid:136468890 ecl:gry
byr:1940
hcl:#fffffd hgt:185cm iyr:2016 eyr:2021

hcl:#b6652a hgt:180in byr:1976 eyr:2022 pid:156cm ecl:#737836
iyr:2013

ecl:amb iyr:2016 hgt:162cm byr:1955 pid:193cm eyr:2028 cid:346
hcl:#733820

iyr:2010 byr:1932 eyr:2025 ecl:grn
pid:595837820
hcl:#341e13
hgt:166cm cid:224

pid:481646831
eyr:2029
hcl:#623a2f cid:319 iyr:2016
ecl:brn hgt:160cm byr:1944

ecl:zzz pid:428329840 cid:238 iyr:2022 hgt:76cm
hcl:#a97842
byr:2024 eyr:2028

iyr:2014 hgt:170cm
byr:1963 hcl:#623a2f
eyr:2026 pid:225910806 ecl:gry

ecl:grn iyr:2010 hgt:193cm byr:1928 eyr:2028 pid:343022641 hcl:#733820

eyr:2023 ecl:grn
byr:1950 iyr:2012 hcl:#866857 pid:400725165
hgt:193cm

cid:195 iyr:2014 ecl:oth eyr:2027 byr:1966
hgt:177cm hcl:#18171d pid:913894485

iyr:2015 hgt:154cm
cid:206
pid:134599284 hcl:#602927
eyr:2023 ecl:brn
byr:1983

ecl:#2d0e7a pid:#f34625 eyr:1942 iyr:2027 byr:2013 hcl:z hgt:162cm

hgt:189cm byr:1965 iyr:2011
cid:178 ecl:hzl
hcl:#b6652a eyr:2026 pid:683560227

eyr:2030 pid:047446524 ecl:grn hgt:167cm iyr:2017 hcl:#602927
byr:1920

cid:86
iyr:1920 hgt:193cm
eyr:2027 pid:401913877 ecl:hzl
hcl:#888785 byr:1953

byr:1991
ecl:grn
iyr:2016
hcl:#5e1ef2 hgt:186cm
pid:076499738
eyr:2025

eyr:2030 hcl:#18171d pid:750694893
hgt:157cm iyr:2020 cid:338
byr:1956 ecl:gry

iyr:2027 pid:#37f002 hgt:164cm ecl:#80df11
hcl:#aeacee cid:320
eyr:2039 byr:1956

iyr:2014 hcl:#733820 ecl:grn
byr:1960
eyr:2025 pid:667089568

hgt:163cm
byr:1962 cid:108 ecl:gry hcl:#733820 iyr:2012
eyr:2029 pid:763684725

byr:1984 hcl:#888785 hgt:159cm iyr:2012 ecl:gry
eyr:2024 cid:236 pid:174711749

ecl:gry pid:044931271
hcl:#b6652a eyr:2029 iyr:2013 byr:1985

byr:1973 iyr:2018 hcl:#a97842 pid:937214113 ecl:blu
cid:247 hgt:186cm eyr:2023

cid:108 pid:231782961 iyr:2017
eyr:2034 hgt:170cm byr:2025 hcl:#18171d ecl:utc

pid:298274796 byr:1928 hcl:#a97842 hgt:188cm iyr:2011 ecl:gry eyr:2028

hgt:65cm iyr:1943 eyr:2025
hcl:z
pid:65702335 ecl:#bb54e6 byr:2010

pid:499116613 eyr:2024
ecl:gry hcl:#cfa07d hgt:193cm byr:1999
cid:278 iyr:2015

hcl:#6b5442 eyr:2027 hgt:175cm byr:1988
ecl:brn pid:410075320 iyr:2010

pid:269678991 ecl:oth iyr:2013
hcl:#602927 byr:1991 eyr:2023

ecl:oth
pid:144593265 hcl:#fffffd
eyr:2020 iyr:2018
byr:1975 hgt:160cm
cid:304

iyr:2014 hcl:#ceb3a1 eyr:2029
byr:1951 pid:520804395 hgt:185cm ecl:oth

hgt:159cm
pid:312887994
cid:205
iyr:2016 ecl:hzl hcl:#866857 eyr:2029 byr:1944

iyr:2023 ecl:#54c85c byr:2030
eyr:1946 cid:190 pid:512417622

byr:1946 eyr:2023 hgt:163cm
hcl:#2d4e9c ecl:brn pid:839043333 iyr:2014

iyr:2027 cid:122 hgt:187cm eyr:1975 ecl:grn byr:1920
hcl:#c0946f

eyr:2029 hgt:189cm ecl:blu byr:1922 iyr:2016
pid:924104599
hcl:#b6652a

hgt:162cm
iyr:2016 byr:1921 hcl:#18171d eyr:1938 ecl:hzl
pid:682222023

cid:118 pid:959515596
byr:1921 iyr:2010 eyr:2029 hcl:#7d3b0c ecl:oth hgt:158cm

ecl:#8ac844 pid:162cm
hcl:8f4d80 hgt:150in byr:2005
eyr:2008
iyr:2017 cid:174

hcl:z byr:1936
pid:255481052 eyr:2021
iyr:2012 hgt:170cm cid:276 ecl:hzl

iyr:2013 byr:1935 hgt:179cm
eyr:2023 ecl:amb pid:073621563 hcl:#623a2f

hcl:#18171d cid:230 byr:1989 ecl:oth eyr:2021 hgt:181cm pid:661224730
iyr:2019

pid:748039140 iyr:2020 eyr:2020 ecl:#6ebbc2 hcl:#fffffd hgt:171cm
byr:1995

ecl:hzl pid:758144605 hcl:#ceb3a1 hgt:186cm
eyr:2028 iyr:2014
byr:1928

ecl:hzl
hgt:66in
byr:2000 iyr:2017 eyr:2020
pid:162973694 hcl:#a97842

iyr:2012 pid:749770535
byr:1969 cid:148
hcl:#733820
hgt:180cm eyr:2021 ecl:hzl

iyr:2010
byr:1958
hgt:164cm
ecl:blu hcl:#733820 pid:890634327 eyr:2024

hgt:70in pid:218397894
iyr:2020 eyr:2025 ecl:gry hcl:#341e13
byr:1970

eyr:2020 pid:854208004 hgt:157cm hcl:#7d3b0c ecl:amb byr:1981 iyr:2020

byr:1924
cid:321 eyr:2028 hcl:#cfa07d iyr:2010 ecl:amb pid:036669613 hgt:170cm

ecl:#6649d4 pid:0026989865 cid:188
hgt:152in
byr:1950 hcl:z eyr:1928 iyr:1963

hcl:#ceb3a1 ecl:grn eyr:2028 pid:074363489 iyr:2010 hgt:173cm byr:1966

eyr:2030
pid:9731612333 ecl:#f8824c
iyr:2022 hgt:161in
byr:2023
cid:316
hcl:z

hgt:175cm iyr:2016 eyr:2024 cid:244
byr:1952
pid:085432899
hcl:#fffffd ecl:brn

ecl:brn eyr:2026 iyr:2017 hgt:75in
pid:745302991 byr:1969 hcl:#7394c7";

        public string seats = @"FFBBFFBRRR
FBFBBBBLRR
BFBBBBBLRR
FBBFFFBLLR
FFBBFBBLLR
FBFFFBBLRL
FBFFFFBRRL
FBBBBBFLLR
BFFFBBFLRR
FFBBFBFRLL
BFFFBFBLRL
BFBBBFBLLL
FFFBFBBLLR
FFBBBFBRLR
FFFBBBBLRR
BFFFFBFRRL
FBFFBBBRLR
BFFFFBFRLR
BFBFBFBRLR
FFBFBFFLLR
BBFBBFFRLL
BFFBBFFRRR
BBFBBFFRLR
FFBBBBFLRR
FFFFBBBLLR
FBBBBBBRRR
FBFFFBBRLL
FFBFBFFLLL
FFFBBFFRRL
BBFFBBFLRL
BFFFBBBLRR
FFBFFBFLLR
FFBFBFBRRR
FBBFBBFRLL
FFFBBFFLLR
FBFFBFBLLR
FBFFBBFLRL
BBFFFFFLRL
FBBBFFFLRR
BBFFBBBLRR
BFFFFFFRLL
BFFBFFFLRL
FFBFBBBLRR
BFBBBBBLRL
FFBBBFFRRR
BFBBFBBLLL
FFFBFBBLRL
BFFFFBBLLL
BBFFFBFRRL
BFFBFBBLRR
BFBFFFBLLL
FBFBBFBLRR
BBFFBBFRLR
FFBFFFBLLL
FBBBFBBRLL
FBFBFFBRLL
BBFBFFBLRR
BBFFBFBRLR
BBFFFFFRRR
FFFFBBFLRL
FFFBFFFRRL
BFFFBBFLRL
FFFBBBBRRR
FBBBBFBRRR
FBFBBBFLLR
BFBBBFFRRL
FFBFBFFLRL
FBBBFBFLLR
BFFBBFFRLL
BFBFFBFRRL
FBFFBFFLRR
FFBFFFFLLL
FFBBBBBRLR
FBBFBFBRRL
FFBFBBFRRL
FBFFFFFLLL
BFFBBBBRLR
FFBFBFBLLL
FBBFFBFLRR
FBBBFFFLLR
BFFFFFFLRL
FFFBBBFLRR
BBFFFBBLRR
FBFBFBBLRR
BFBFBFFRLL
FFBBFFBLLL
BBFFBFFLLL
FFBFFBBRLL
BFBBFFBLLR
BFFBBFBLLL
FFFBBBFRRL
FFBFFBBRRL
FFFBFBFLRL
FBFFBBBLRL
BFBBBBFLRR
BFFFBFBRLR
BFFBBBBLLL
FFBBBBFRLR
FFFBFFFLRR
BBFFBFFRLL
FBBFBBFRLR
FBFFBBBLRR
FBFBFFFLRR
BBFBFFBRLR
FBFFBFBRLR
FBBBBBFRLR
FBBBBFBLRL
FBBFBBBLLR
BBFFFFBLLR
FFFBFFBLRL
BFBBFBFLLR
FBFBBBBRRR
FBBFFBBRRR
FBFBFBBRLL
BFFFFBFLRL
FBBBFBBLLL
FBBFBFFRRL
BFFBBBBLRL
BBFFBFFRRL
BFFBBFFLLL
BFBBBFFRLL
FFFBBBFLRL
FFBFFBFRLR
BFFBBBFRRR
FBFBFBBLLL
BBFBFFBRRR
FFFBFBFLLR
FFBBFFFRLL
BFFFBFBRRL
BFFFBFBRLL
BFBFFBBRLR
BFFBFBBLRL
BFBFFFFRLL
FBFFBFFRRL
BBFFFBFLLR
FBBFBFBRLR
BFBFBBBLLL
BFBFBBBLRL
BBFFBBBLLL
BBFBFBFLRL
BFBFBBFRLR
FBFBBFBRRR
FBBBFBBLRL
FFFBBBFRRR
FBFFFBFRRR
BFBBBBFRLR
FFFBFBFRLL
BFFBFFBRRL
FBBFBBFLLL
BBFBFBBRLR
FFFBBFBLLL
FBFBBBFLRR
BFBBBBFLLL
BBFBFFBLRL
BFBFFBFRLR
FBFFBBBRLL
BFFFFBBLRR
BFFFFFFRRR
BBFFBBBRRR
BBFBFBFLLR
BFFBFFFRRR
FBBBFFFLLL
BFFBFFFLLL
FFBFBBFLRR
FFBBFFFLRR
BFFBBFFLLR
FFBBBBFRLL
BFFBBBFRRL
FBBFFFFLRR
FBBFFFBLRL
BFFBBBFLLR
FFBFBFFRRL
BFBBFFBRRL
BFFFFFFLLL
FFFBBFFLLL
FBBBFBFLRR
FBBFFBFLRL
BFBBFFBRLR
BBFBFBFLRR
FFBBBBFRRR
BBFFBBBLLR
FFBBBFFLRR
BBFFFBBRRL
BBFBFFFLRR
BFBFBBFRRR
BFFFFBBRLR
FFFBFFBLLL
FBFBFBBRRR
FFBFBBBRRL
BFBFBFFRRL
FBBBBFBLRR
BFFFFFBRRR
FBBBFFBRLR
BFBFFBBLLL
FFBBFFFRLR
FBFBBFBRRL
FFFBFBBRRL
BFBFFFBRRR
FBFBFFFRRR
BFBFFFBLRR
BFBBFBFRRL
FFFBBBFRLR
FFFBBFBLRL
FBBBFFBLLR
BFFFBFBLLR
BFBFBFBLLR
BFBBBFFRRR
FBBBBFBLLL
BBFFFBBLRL
FBBBBBBRRL
FBBBFBBRRR
FFBFFBFLLL
FBFFFFBLRL
FBBFFBFLLR
FFFFBBFRRL
BFFFFFBLLR
BFFFBBBLLL
FBBBBBFRRR
FFBFFBBLRL
FBFFFBBLLR
FBBBBBBLLR
FBFFBFBRLL
FBBBBFFRLR
FFBBFBFLRL
BFBBBBBRLL
BBFBFFBRRL
FFBFBFFRLR
FFFBFBFLRR
FFBBBBBLRL
BBFBBFFLRL
BFBBFFFLLR
BFBFFBFLRL
FBFBBFFRLR
FBFFFFFLRR
BFBFBBFLLL
BFBBBBFRRL
FFFFBBBRLL
FFBBFFBRLR
FBBBFBFLRL
FBFFBBFLLL
BFBFBFBRRR
BFFBFBBLLL
BBFBFFBLLR
FFFBBBBLRL
FBBBFBBLRR
FBFFBFFRRR
BBFBFBBRLL
FFFBBFBLRR
FFBFFBFRRL
FBBFFFFRRR
FBFBBFBLRL
BFFFBFFLRL
FFBFFFFRLR
BFBFBFFLRL
FFBFFFFRRR
BFFBBBFLLL
FBBFBFBRRR
FFBBBBBLLL
FBBFFBBLLL
FFFBBBBLLL
BBFBFBBLLL
BBFFBFFRLR
BFFFBFFLRR
BFFFBBBRLL
FFBBFBFLLL
BFBFFFBRLL
FFFFBBBRRL
FFBBFBBRRL
FBBFFBBLRL
FFBFBBBRLR
FBFBFFBRLR
FFBBFFBLLR
BFFBFBBRRL
BBFFFBFRLR
FBBFFFBRLL
BFFFBBBRRR
FFBFFFBRLL
BFBBFFFLLL
BFFBBFFRRL
BFBBFFBRLL
FBBBBFFLLL
FBBBFBBRRL
FFFFBBFLRR
BBFBBFFRRL
BFFBFFFLRR
FFFBFFBLRR
BFFBBFBRRR
BFBFBBBRLR
BFFBBBBLLR
BFFFFBBRRL
FFFBBBBRRL
FFBBBFFRRL
FBBBBBFLRR
BFFBFBFLLR
BFBFBBBRLL
FFBFBFFRRR
BFBBBFBLLR
FBFFBFFLLL
BFBBBBBLLL
BFBFBBFRLL
BFFBBBFLRL
BFBBFBFRLR
BBFFBBBRLR
BFFFBBFRLL
FFBBFBBRRR
FBFBFBFRLL
FBBFFBFRLR
FBFFBBBLLL
BFBFFFFRRL
BFBBBBFLRL
BFBFFBFRLL
BFBFBFBRLL
FBBFFFFLLR
BFBBBFBLRL
FFBBFFBRLL
BFBBFBFLLL
BBFFFBFLRR
FFBBFFFLLL
BBFBBFFRRR
FBBBBBFRRL
FBBFBFBLRL
BFFFFFBRLR
BFBBBBBRRR
FBFFFBBLRR
FBFBBFFLRL
FFBBBBFRRL
BFFFBBFLLR
BFFBFBFRRL
FBFFFFBRLL
FBFFFBFRLR
FFFFBBFRLR
BFFBBFFLRL
FBFBFFFRRL
BFFFBFFRRR
FFBFFFBRRL
FBFFBBFRLL
BFFBFBFRLL
FBBBBBFLRL
FFBBBFBRLL
FFFBBFFLRL
BFFBFBFLLL
FBBBFFFRLR
FBFBBFFLRR
FBBBBFBRLL
FBBFFBFLLL
BBFFFFFLRR
FFFBBFBRRL
FBFBBFBLLR
FFBFBBFRRR
FBFBBFBLLL
FBBFBFFRLR
BBFFBFBLLR
BBFFFFBRRR
FFBFBBFLRL
BFBBFBBLLR
FFBBBFFLRL
FFFBFBBLLL
BBFFBBFLRR
FFBBBFBRRR
FFBFBBFRLR
BBFFBFFLRR
FFBBBBFLLL
FFFBBBFRLL
FBBBBBBLRR
FBBBBBFRLL
FBFBBBBRRL
FBBBFFFRLL
BFBFBFFLRR
FFBFBBBLLL
FFBFBBFLLL
FFBBFBFRLR
BBFFFBFRLL
FBFBFBFLLR
FFBBBFFLLL
FFBFFFFLLR
FFBBBBBRLL
FFBBFFFLLR
BBFFFBFLLL
BFFFBBFRRR
FBBBBFBRRL
BFBBFFFRRL
BFFFFBBLRL
FFBBBBBLLR
BFBBFFFRLL
FBFBFBBLLR
FBBFBBBRRL
BFBBFFBLRR
FBFBBBFLRL
FBFBBFFRLL
BFBBBBBLLR
FBBFFFBRLR
BBFFFBBRRR
FBFBFFBRRR
FFFBBBBRLL
FFBFFFBLRL
FFBFFBFLRR
BFFFBBBLLR
FBFFBBBLLR
FFFBFFFRLL
FBBBFBBLLR
BBFBBFFLLL
FBBFBFBLLR
FBFFBBFLRR
BFBFFBBRLL
BBFFBFFRRR
FBBFFBBRRL
BFFBFFBLRL
FFBFFFBLRR
FBFBFFBLLL
FBBFBFBLLL
BBFBFBFRRL
BFBFFBBLRR
FFBFFBBLRR
FBBBBFFLRR
BFBBFBFLRR
FFBFBFFRLL
BBFFBFFLRL
BFBBBFBRLR
FBBFBBFLRR
FBBBBBBLLL
FFFBFFBRRR
FFBBBFFRLR
BFFBFBBLLR
FBFBFFFLLL
FBBFFBFRRL
FBBFBBBRLL
FBFBBBFRLR
BFFBBFBLRR
BBFFFFFLLL
BFFBBBFRLR
BFFFBFFRLL
FFFBBBFLLR
BFFFFFFRRL
FBBBBFFLRL
FBFFFFFLLR
FFBFBFBLLR
FFBBFFFLRL
FFFBFFBRLL
FFBBFBFLLR
FFFBFFBRRL
FFFBBFBLLR
BBFFFBBRLR
BFFFFBFRLL
FFBFFBBLLL
FBFBBBFLLL
FBBBFFFRRR
BFBFBFFRRR
FFFBFFBLLR
BFFBFFBLRR
BBFBFBFRLR
FFFFBBBLRL
FFFBFBFLLL
BFFFFBBRRR
BBFBFFBLLL
BFBFBBFRRL
FFBFFBBRLR
FFBBFFFRRL
BBFFBFBRRL
BBFFFFFRLR
BFFBBFBRLL
BBFFFFBRRL
FFBBBFBLLL
FBBFBBBRRR
BFFBBBBRRL
BFFFFFFRLR
FBBFFFBLRR
FBBBBFFRRR
FBFBFFFLRL
FBFBBFFLLL
BFBFBBBLLR
FBBBFFBLLL
FBFFBFBLLL
BBFBFFFRLR
FBFFFBBLLL
BFFFFFBRRL
FBBFBBFLRL
FBFFFBBRRL
BFFFBFBLLL
FFFFBBFRRR
FBFBBFFRRR
BBFBBFBLRL
BBFBFFFRRL
BFBFFFFRLR
FFFBBFBRRR
FFBFFBFLRL
FFFBBFFRLL
BFFBBBFRLL
FFFBFBBRLR
BFBBBBFRLL
BFBFFFBRLR
BBFFBBFLLR
FFFFBBFRLL
FBBBFFBLRL
BBFBFFBRLL
FBFFBFBLRL
BBFFFBFLRL
FFFFBBBLLL
FBFFFFBLRR
FBFBBFFLLR
FFBBFFFRRR
BFBBFFBLLL
BFBBBFFLLL
FBBBBBBLRL
FFBFFFFLRR
FBFFBFBLRR
BFFBBBBRLL
BFFBFFBLLR
BBFFFFFLLR
BFBFFBFLRR
BBFFBBFRLL
BFFFBBFRRL
FFBFFBBLLR
BFBBFBBRLR
BFFBFFFRLL
FFBBBFFLLR
BBFBBFFLLR
BBFBFBBLLR
FFBFBFBRRL
BFBFFBFLLR
BFFBFBFRRR
FBBBFBFRLL
FFBFBFBLRR
FBFFFFFRRL
BFBBBBFLLR
FBFBFFFRLL
BBFFFFBLRL
FFBFBFFLRR
FBFBBBBLLL
FBFBFBFLRL
BFBBBFBRLL
FBFBFBBRLR
FBBBBBBRLL
BFBBBFBRRR
FBBBFBFRLR
FBFFFFFRRR
BFFFFFFLLR
BFBBFBBRRR
BBFBFBBRRR
BFBFBFBLRR
BFBBFBFLRL
BFFFBBBRRL
BFFBFBBRLL
FBFFFBBRLR
FFBBBFBRRL
BFBFFFBLRL
FFFFBBBRLR
BFBFFBBRRR
FBFFBBFRLR
FBFFFBFLLR
FBFBFFBLLR
BFFFFBFLRR
BFBFBFFLLR
FBFFBFFLRL
BFBBFFBRRR
BBFFBBFLLL
FFFBFBFRLR
FBBBBBFLLL
FBFFFFBRLR
BFFBBBBRRR
BFBBBBBRRL
FFFBBFFLRR
FBBBFBFRRR
BBFBFBBRRL
FFBBFFBLRL
FFFBBBBLLR
BFFFFFBRLL
FFBFFFBLLR
BFFBFBBRRR
FFBFBFBLRL
FBFBBFBRLR
BFFBFBBRLR
BFBFFFFLRR
FFBFBBBRLL
BFBBBFBLRR
BBFFBFBRLL
FFFBBFBRLL
BBFFBFBLRR
BFBBFFFLRL
BFBBFBBRLL
BFFFBBBLRL
BBFBFBFLLL
BFBFFBBRRL
BFBFFFFLLL
BBFFFBFRRR
FBFBBBFRRL
BFFBBBBLRR
BFBBBBFRRR
FFFFBBFLLL
FFFBFBBRLL
FBBFBBFLLR
FBFBFBFLRR
BFFFFFFLRR
FBFFFFFRLR
BFBFFFFLLR
BBFBFBFRLL
FBFFFFBLLL
BBFBFBFRRR
FBBBBBBRLR
BBFFBBFRRR
BFFBFBFLRR
FBBFBFFRLL
BBFFFBBRLL
BBFFBBBRRL
BFFBBBFLRR
FFFBBFFRLR
FBFFBBBRRR
FFFBFFFLRL
BBFBBFBLLL
FBBFBBFRRL
FBBFBFBRLL
FBFFBBFRRR
FBFFFBFRLL
FFBFBBFLLR
FBFBBBBRLR
BFFBBFBLRL
FFFBBBBRLR
BFFFFBFLLR
FFBBFBFLRR
FFFFBBBRRR
FBFBFBFRRR
FFBBFBBLRL
BFBFBFBRRL
BBFBFBBLRR
FBFFFFFLRL
FBFBFBFLLL
FBFBBBFRLL
FFBBBBBRRL
FFFBBFFRRR
BFBBFFFRLR
FFBFFFFRRL
BFBBBFFLRL
FBBFBBFRRR
FBBBFBBRLR
BFBBFBBLRR
FBBFFFBRRL
FBFFBBFLLR
FBBFFBBRLR
FFFBFBFRRR
FBBFBFFRRR
BFBBFBBLRL
FFBFFBFRRR
BFFBBFFLRR
FBFFBFBRRL
FFBFFBFRLL
FFBBBFBLLR
FBFFBBBRRL
FFBFBBBLRL
BFFFBFFLLR
FBFBBBFRRR
FFFBBFBRLR
BFFBFFBLLL
FBFFBFFRLR
BBFBBFBLLR
BFFFFBBLLR
BFBBFBFRLL
FBFBBBBLRL
FBBFBBBRLR
BFBFBBBLRR
BBFBFFFLRL
FFBBBBBLRR
FBBFBBBLLL
BFFFFBFLLL
FBBFFFBRRR
FBBBFBFLLL
FFFBFFBRLR
FFFBFFFLLL
FFFBFFFRRR
FBFFFBFRRL
BBFBFFFLLR
FFBBBBFLRL
FBFBFFBLRR
FBBBFFFLRL
FBFFFFFRLL
BFFBBFBRLR
BBFFBBBLRL
BFBBBFBRRL
BFBFFFFRRR
FBBFFFBLLL
FFBFBBBRRR
FFBBFBFRRR
FFBBFBBRLR
BFBBBBBRLR
FBFFBFBRRR
FBFBFBBRRL
BBFFFFBLLL
FBFBFFBRRL
FFBFBBBLLR
FFBBFFBLRR
FBBFFFFLRL
BFFBFFBRLR
FFBBFBBLLL
FBBFBBBLRL
BFFFFBFRRR
BBFFFBBLLL
BBFFBFBLRL
BFBFBFBLLL
FBFFBBFRRL
FFFBFBFRRL
BFBFFBBLRL
FFFFBBFLLR
FBFBBFFRRL
BFBFBBBRRR
FFBBBBFLLR
FFBFBBFRLL
FBBFBFFLLL
FBFBBFBRLL
BFBBBFFLRR
FBBBFFBLRR
BFFBBFBLLR
FFFFBBBLRR
BBFFFFFRLL
BFBFFBFLLL
BFBFFFBLLR
BFBFFBFRRR
BFFFFFBLRL
BBFFBBBRLL
BFFFBBBRLR
FBBFBFFLLR
FBFFFBFLRR
FBBBFFBRRL
BFBBFFBLRL
BFFFBBFRLR
BFFFBFBLRR
FBFBFBFRLR
FBBBFFBRRR
FFBBBFFRLL
FBFFFFBRRR
FFBBFBBRLL
FBBFFBFRLL
FFFBFBBRRR
FBBFFFFLLL
FBFFFFBLLR
BFBBFFFRRR
FBBBBFBRLR
FFBBFBFRRL
FFFBBBFLLL
BFFBBFBRRL
FBFFFBFLRL
BBFBFFFLLL
BFFFBFFRRL
BFBFBBBRRL
BFFBFFFLLR
FBBFBFFLRL
FBFBFFFLLR
BFBFBBFLRL
FBBBFFBRLL
BFBBBFFRLR
FFFBFFFRLR
FBFBBBBLLR
FBFFBFFLLR
BFFFBFFRLR
FFBBBFBLRR
FFBFFFBRRR
FFBFBFBRLR
FFBBFFBRRL
BFFFFFBLLL
FBBFFBBRLL
BFFFBFBRRR
BBFFBBFRRL
FBBFBFFLRR
FBBBBFFLLR
BBFFFFBRLL
FFBFFFFLRL
FBBFFFFRLL
FBBFFFFRRL
BFFFBBFLLL
FBBFFFFRLR
BFBBBFFLLR
BFBBFBBRRL
BBFFFFBRLR
FBBBFBFRRL
FBBFFBBLRR
FBBFFBFRRR
BBFBFFFRRR
BBFFFFBLRR
BFFFBFFLLL
FFFBFFFLLR
FBBBFFFRRL
BBFFFFFRRL
BFBFBFFLLL
BFBFBBFLLR
FBBBBFFRLL
BFBBFBFRRR
BFFFFFBLRR
FFBBBBBRRR
FFBFFBBRRR
FFBBBFBLRL
FFBFFFBRLR
FBBFFBBLLR
BFFBBFFRLR
BFFBFFBRRR
FBFBFBFRRL
BBFBFFFRLL
BFFBFFFRRL
BFBFFFBRRL
BBFFFBBLLR
BBFFBFFLLR
BBFBFBBLRL
FBFBBBBRLL
BBFFBFBRRR
BFFBFFFRLR
BFFFFBBRLL
BBFBBFFLRR
FBBBBFBLLR
FBBFBBBLRR
FBFFFBFLLL
FBBFBFBLRR
FBFBFFBLRL
BFBBFFFLRR
FBFBFFFRLR
FBFFBFFRLL
FFFBFBBLRR
FBBBBFFRRL
BBFFBFBLLL
FBFBFBBLRL
BFBFBBFLRR
BFFBFBFRLR
BFBFFFFLRL
BFBFFBBLLR
BFFBFFBRLL
BFBFBFFRLR
FBFFFBBRRR
BFBFBFBLRL
FFBFFFFRLL
FFBBFBBLRR
FFBFBFBRLL";

        public string customsForms = @"gsvdkufnoawjmhp
wvhusojpnikgfadb
vshnpfedgwajkou
aujodhskfvnpgw
okpdnwhsfvjguqa

juedvq
vqeduj
veqdju
eqduvj

cdajbuernxm
mnucjearxbd
axrmdejuncb
jrebucmdxna

kutplibdoqzfvhw
qcewmrkdvhl
qobdwvlkgxhpasyjn

psbjhnatxe
pnaxesjhbt
tpxhbnseaj

yskvjqacinfdrphwltxgzomueb
jwprnxzvkeofthuqbyimadgslc

hzwepdg
lwf
wy
lw
rw

sdgateubqmznhjk
xyphltd

dbhl
hdlb
dbhl
hbld

inkxywsbgjuvpztrecadqmhf
qkaxszcujwvmbhdietpgr
krupsdgibzecxwvhqatmj
qtpxerobhisgcumkwjvdaz

bgakcmh
gxasvzu

cjtrvhinaqsbpk
jvxtspaqbhkfnrc

nab
bex
qmkudf

uot
out
tuo
uto
out

sbtkzf
hbkfzs
szbkf
fuzksbx
jskrzbf

dkphfoybsagcrnq
oybunchapqrdks
bokpysdhqnarc

bchumknwairvlf
cvbuhwzirkalfy

bwnseiaoqyjf
josqanfbew
nealmqbfwojs
jqnbfaoesw

sowzuji
wojizu
wzojiu
jwozui
ujiwoz

kcopqbt
tpkudorbc
pmtwogjb

uxkfthszqdbelomwri
tlusezbomwfqrdxhki
rsdfkbteoqilzmxhuw
bwkqmdsxhrfulietoz
izkwomsdlbfxetqhru

kzhwyodlvpt
kvfhldwpo
lvhypokdw
opwjhvdkcl
kpahtdolvw

cldyjpuitah
upcthlijyda
icdauhpytj
haypidtucj
jidaptcyhuo

mi
ti
qjwiz
oudehsxyiv
bpirjl

stlyornuk
cxapqwie

kharunjiebzvoy
gvaihtklnqmcebf

t
lt
t

ohca
lznkumqfgyjsbeot
owxdivpr

dy
yo
xsy
yo
pyrvh

iaxp
afpikux

hpsfqrnevzxl
fnrsvexzhqup

cp
fpc
cp

nbuojxgqckrwzspehf
mhguoxsfkejwcq
kedqujsomfxhwcvg
ouqefsxchgjkw
qcjohwxfseugk

rybnlomq
fmxsngauo
embkon
nlmvob
bomhnv

gptixlduzjeqkorsamwnh
pgzwohfjkuvbtylmc

thcgo
vhrlxmo

kbfgmhpzoqysac
ockazbsmhpgqfy
kmcqfyzhapgsxb
qcfdlwyarzuskhmbg

surovlcihp
irvlpuhosc

rd
d
td
d

koasgulh
kroumtzl
yubkwolnpj

dqykvasneb
easknpbovyjd

wqvop
nwqvpo
wovfrqizh
onqpwv

uskotfndjeplixhycbqrmw
mbxoewypcfdhistn
ydtvpbfemcnsihoxw
ynwbtosmcipxhfde

urgvbqechawznsjltixody
swdbnevcatrflguhziyoqxj
sgiwelhanovrbjuzyqtdcx
vyenojuhxwzbtigsdqarkcl

jxcwblszo
khrwvnbdolgjufyz

n
r
d
r
bd

tolrypvdwmb
lwrmopdvybt
rdybwmvplto
vlwpyrbmotd
ybolwtvprmd

radvoplnq
lrqpondva
lpanovqrd
lpanvoqdr
dqorvalpn

fvxca
vacfx
fvcxa

jbeixdakgolpfhqyntw
purbsxvjfwhetlmcnz

jztfgbmnkadiehv
djhpntcizmkgvbfe
btegdfknizvmhjl
igbdeztjfkhmnv
iqvtgejanzfdbhmk

jpi
ijp
ijp

kydp
viykd
dgyqmftwx
vdye

sewpkrvh
ekorswnp

bplerysifmzvwoncjxqk
nsbeqowitcpjymxvl

nexbskamprd
xsmdbkaupner
dsbnekarctvmpx
nkapxcbsmrlde
ezfdhnakwrsmyxpb

olnuzvxcgpdtfb
tgzcfdbnxp

vjliksorxpmwecaznu
giuoxsvnzewljpmc

fuljpkt
cplftukj
lfptjku
futpjlk

tqcgihveyswu
ywvqecthgs
cqhwetvsyg
qvshwcegty
gyctwqsfvhe

uhezlyxwvpcidr
hvucplszbxywer

jchyntk
revwzsm
kdn

cotikdlpxauzb
uxzptoksqbdiw

nqvruwhtombs
tebfnykzmlgcj

ciwkhzbmgfqo
uwmzgbcoihqkfs
fkwmziohcgbq

shezgrvq
gprveokq

jvqcdiuyrnpgh
dyjqvhrpic
xjiklpfzmthrwdsyqv
pdyvochrunaqjgi

denpjgywacrk
jbypwarecukdgn
zacqyxdgejrmpwkfnh
uwldpkrgaenjcy

q
mq
q

d
c
d
d

cdazeitlrpxnfqs
nrqxelfocsihpz
cnkveyiujlbzfgrpxq
cqznxrfliedp

qicgkpjzlxonv
cijozlhkqxnp
pgkcnloyxzj
japmxlknszotc

bytg
mwetjayhgiup
gyt
ygt
tyg

zx
elxz
z
vncto

nryw
rywn

takqgijzforxpshm
ztmrxfqgsiphjaok

fsaoqe
wcavsldeytn
auoekhzsi
hgseja

whqyvldpintefaxgurjc
xluqrgsvnacykptefbdhmj

oylknhsgmpawziqte
znhmatkpolsw
pkvmtznhlwsoa
onzamhltkpsw

zs
zs
zs
sz

e
a

xmi
gahfrd
yt
jmy
nqy

zkbtfdjom
ot
uoqtr
eot

g
er
g
g

ncvwupezd
cnvdwzpeu
cuwnzvedp
cdnzevwpu

bkuwcsv
bqcsgwve
mbhcovjsw
qwrnbeycsv
lisvbwc

vlys
omvzl
ptlejv
xylv
vxol

mqgohwtz
rqomlcw

rgopxhkslqcjmzbatnd
phgzmojlstadqrxkbn

pcbziv
pivzbc
jilczbpv

gmrecszl
zgrecslm
melzcrgs
gezcrlsm
mcsezrlg

ceotvxaydplfiu
vbzcaxuokwd

gy
g

lj
neocbiqjt

foyawivmhs
fayowsmzrv
mksfowvzayg

sivthk
yh
lh
ybhq
hy

fk
ka
vka
qhjxrzmckpb
kf

s
s
s

iyth
tyhri
yrtaih
htyi
utifydhq

hwxd
xhwd
hxwdb

kfhsvbjdwxcnt
dbfjhsctkvw
sogzdhjqiwmlyuvf

v
nyx
v
i

ncimwelvbudtp
piwvudaer

aktpdrhm
dtapkhr
dhapktri
taprnhdko
krpdhta

fvpaxk
zgmrwja
ar

vxoisla
olisvxa
kioqvrlxjhsya
oixgalsv
savloix

ac
gr
c
tl
c

fndwqsruzagei
dwunqfaesgzri
bzarmfnqwuisgde

jr
rj
jr
jr

zrevhj
xigdmqatk
wjlpzvsy

qijznvobp
nzbojivdpc
vzipojnb

srbtecvpixam
hdvctplmfxuow

bf
bf
bf
bfex

g
g
g
g
mag

b
y
b

vmbwhdfiqteglnpkxucjoa
wmqdconxbuaetjlgphivkf
upadfnhkwtjioqcbvxelmg
gofjubptnmkelihwxacqvd

alev
evla
alve
avel
aelv

uceyogrhl
oqcafluvhewgr
ugcxlhorpez
nduzshrceglox
odmgbeucrplh

ugesfliovyzja
nlizsujfadgo
lfguaszotij
osznifulgadkj
xadguljioszf

kpgve
vqsfezungalxidb
gwteov
gpvcyjrmeh

apuonkxtc
xithys
hfvtsx

pgtzamyqeu
gtiuwpcqzvya
tpqauezyg

souvmglcqbekzi
miuzvksocgqbel
gzqkmsubevolci

ndvahciz
jaoyhepsbirw

bghijfkotcxwu
uaokxsfbleyhgqr
hucfokpwbxg
nbfuztgovhxk

zghianxtlq
qthdvingxalkz
wfqnixgteza

lhzcrodupwqsv
phsvrzcldoqwu
hogspqwcvukdz
hwzpucdsqvrol

txkqmsfbglhnoypaduiv
navlozmpthwsbkiqxdfu

gidnojlbtfpskuwavyxczr
irvsyznbtedxougfwc
sovxhcqdbwytzmugrinf

mcjnraketsgvqyxpbuwlhzdof
kqudanprgiejcftzlywhsoxmb
rcxmkdqfohjzgtsalbpunywe

o
cm
rc
m

tmkbedxgzsw
tdgmsxbzkernw
ktdbxzsemgw
gwkmestbdxz
xzdewgtmskb

evpdgzcu
gepcvzu
vegzpuc
vpuzgec
cvpgeuz

wfsadgtuizejmylxq
aspmuqigbxeljdtwfy

ygbtdp
tye
fryaitjcukhl
ytdm

jfm
m
m

cl
cl
lc

qbodnftrsygi
iztorbfskqdvng
onpsgqrdtif
mnrofcuqwdtils

mhavcgzlrtbo
jrldgavzqbcxoh

pshtdbifrvzqmklyae
tfajgrpkidzyhslebmvq

cuzbjepnvis
isjbenvyzlcup
nagieshzcpqmfuvbj
ezvpsjrnciub

ywgdsafzuxbrmhvqkljnoipc
hjcntvrzwdfbxksyiqolpumag
kwvpybmjeoualxcsqgidhfnrz

zubvkn
cuwfsnv

isknfdalujeg
hikagvpzx

szgfhjtxid
stdgjzxfih
xghsjfdzit
gfjixszhtd
fzjshdtixg

uibgxka
abigukx
xubakgi
gxabiuky
bkaxgui

tjzor
slaore
gxwnoifudmcqvpk
obhr
tyo

q
y
e
r
ifdcxzm

fvtqrjsblkhuoiey
gyfnizlqupvscobt
bouiftlcvqsy
qdvlyfiusgotb
qvbycwsifluto

ifmnxbcvpkylruh
nckrmfphluixvby
vbcmxyhurnpilfk
suiqbvyrxcphmfnlk
ynuxkrfvibclpmh

pmvdyexsoilatqfgk
lpidgatmqevkxyso
gkpsaoleymqxvtdi
gmvxeyplqdoasitk
vkpdylstquegaiomx

ymogxuswkce
vbxznpscg
xlcgs
xclbdsng

zovwtiy
zrjlciov
ksxefuvqdam

cwvsx
xeuwyhsfb

hxwgolksbrdmpifye
lwpyefxmiohdnbksgr
gzoehypbldxikmwtrfs
sdlwpeymxifrbghok
glmbhykiofdxpwervs

ndcphgqfuvsekaxozri
xofkqnbschdaveruizgp

ptkvdhjaw
skhtapidwjn
thunakpjwd
eaglphkdtjcfw

pnezvfgiouahmslkdxcrqb
fpiqsecxaukbvzgnorjhwdm

emcwblgxuvnkzrdsoyjf
rvsxeugkmwzfncojlb
nhbiclvskjrupgxzfeomw
gcxlbjozeiufwnskvrm
eonjkwbzfxgpruvcmsl

ntgia
ia
ai

scoernukhwtigpd
bogiserhpucnkt

eaipzg
gne
lughe

tbipylmnrague
tbargijepmhuynl
triyzgupnbmale
prtnumgaibley
peblaytmgnrui

rqlsepfhiv
fvelqphsri
ilfhvqerps
fheqplsvir
sfpvehirlq

jciwxfbhqkadgzloprnuvsty
qwouetsmhykavxfbjzrglc

fjmz
mjczf
unkzjm

gebyncxsphfokwm
gmchsnbwkpfyxeo
fybkhcesogxpwmn

ud
whjn

ihm
hmi

p
p
yp
sp

ytrwx
yrtxw

p
d

ieltygdukac
yiudeakg
kpegdaiyu
audykegi
aeqydwiguk

lb
ei

zjvctfndgiqbeu
abfwndutvecqigz
fznbdutevigcq
qtvzfnueibdcg

g
i
x
g
g

qhm
lq
nq
pqsb
lvq

qnxpslvajf
xuavcnst
nsyabxv

ocu
uco
acoux
cluo
coun

jtgzodebq
ojztqdgbe
oejrqzgtbda
tjzbqedgo
gzqtejobd

ubglorcsyvmxd
oentwfgulpqikdcbzhj

jwkmxdnyvbiz
qebnoyfz

bepdfi
ikepbof

cofgekndbatpruhqmwvsiy
bsqtrakeudopghvyfmcnw
qgusdwvabytmfkcnehorp
qfhruygwkvmbpaoestcdn
prmkbuvynseatdoqwfhcg

enczdvbkiyjgruqp
bdiqvwjurpycngzk
bnrcejupvqiwgzkyd
pqgybrcjzkudonvi

fygasxjwrb
ijsgafwyrbx
syjawbxgfr
wfbrgvsjyax

xtp
bfnzuadh
xlce

rxmeqcbv

fjtdihkrbyn
htfjyinkgdrb
fibgtkdryhnj
hkbnjrftidy
intbxjrkfdyh

nhkiqjocfgxmrvwetd
ghnfdjvqtxwermokci
xnrtfkhdwcmjvoeigq
mcvfjhwiqtnrekogdx
imhxgjwrodtcknqvef

sabwqu
yqamws

usei
xkvnyfi

rcewysztbiamhpgldj
kibrfndmgeazcsh
adrzgchmwjsbie

pnrwvx
lwjxnu
vwxinb
pfxybwng

wnvxgfdkubzrmip
kmjhoigltwbz

znlgbx
fla
dl
l
l

jgeqcikplduzxrwby
kwplxgcbndjqyizuer
ewrqujilgyxpdzcbk

guteykxsqrfwhz
mhiurkswtqbxz
sdlqxvowujrhkz

zrejn
nzrje
jnerz
rzjen

fvkouigderaqbjth
eqrvwjinfltzpcuag

stqcrpy
ctsqpyr
ptyqrsc
ymsqrcaptb

egftpqosiv
ecjdqlnmwouf
spxaqofre
epogyfqi

oxwgtshjqef
pbtgjfeqhnoxw
jfhewygoxtq

jwavgo
ogevbwdjai
ogvahjw
wrajvog
ogsjwarv

rpucvg
cgpr
htfelpc

hqrwapscubelovxntd
jisztpnbcahlfdoqmvexgk

pmadwutiejznofcgvsbqyxh
qvmzbaisgfcunwjexhpdktyo
xtvsdnqaucyehgzbjiopwmf

vjqih
himjwdv
hsojivb
jtrklivehyg
mvnaizoqpfxhj

j
j
j
j
j

dpnwmtvklc
ndjpkm
ndmpk
ndmpk
ndmpk

ucojsptiqymhewbxvrfdkngl
ebpjwuxrdqkmsochvfgliznt

esroiaqdbxnjhut
xibuqhmensdajo
feukjbahdxwqnsiocv

vkxzclpmtujngerawod
azdrgcenvjxptkuolmw
onrluajvcgewpdzkmtx
xamlobkrvzwpjgnucdte
tvenjdmlzpwugkoracx

ywpfhztklgjmoien
nyelduixgvwmojpzhtk
lehpigtmoknjyzw
gmhwzokylpnteji
tmypejhwgzlniko

fmd
jf
fj

l
v
ntobg

drmzvt
rxtsfuk

vxdlpjkrsz
dgxkprvzsl
dsklxpvzr
pdvxzlrsk

gwip
gakpw

kbcadn
bakcd

mhpstqcgvoalkwxinebryzujd
qwhirveoczyatgjdsmkpxnl
mejazlincwodtshxkrpgqyv
fsaizhnkcvwolgjpdqxtmrye

rxubznovy
yvudnrbz
zvunwcyrkb
ntzbryuav
ndvytuzrb

utvklrxypgbnimsdofwa
fyzliqswjmtpvdka

byctfzx
pxzf

g
ik
ykei

bcajzwogvetd
gedbcwtzvoaj
hcwogaxjbzvted
eoczjagtdwbv
atvdjbcozgew

wsclketugyaz
qvfbjcxtmilgow

amgirw
yf

iletugq
hnoxbfkaspt

qjdfcpvksmxzywahgn
wnzceyskgpoxdhlmravjqf
xjgvhcsqyfankpzmdw
jyncdxwsqkvphfamgz
dvznygwjkcmqsxahfp

fkuwiezpljbdayhsr
rphwbeujdzlfiasyk
erdhpafkzbwjlusiy
jwfhkrzdeabpliusy
wfipeujhylazbsrkd

fqmbwapvouelydgicj
uelvqwomtyfjgcpadi
qkpcsdeyjiwarovnglfum
ijvgqdauoefpcylwbm
ydmqpfewaovlicugj

sgbq
ltqambf
djbuvn
zmtbgy

egvifnsaztxqcrywumj
aqcxujnzvfwetrhgm
fxdmtkgawplobqjenv

bxuwpnl
ztdkau

ecylsbdv
cvzlsbeyd
yqcveblsd
beyvlqcsd
ebsvdycl

eb
xpnyter

cbhqyzresnpxfwm
cwksfvhxqperbimz
whqzpbcsjxafre

beodiasvj
jbisdoave
iedaovbsj
jxovacsiebd

prxsnyehgwifbzo
ozpbsxynfiwrge
ribozypewsxngf
nyoxspzbfihgewr
rxzewpbnimfoysg

shviadjcue
weduziolmcbngp
vqdieycu
cudeif
dicyuqke

nvcwhuo
sltchuwnq
unwhci

ekrisbvx
rsxiev
exnrvsi
srxevi
xhsvnrei

rs
rs
sr

fuzjmek
tihf

ptlzxreqfdchibogvysmku
pceyizvdkqxbhrtulsfmog
gvkrxfsbipqedlyzomhtncu
suyzgrobilxhmcfdtvkeqp

okfvjneqyicuthwsmpxl
wdojlsqknyhmptvicfe
nyfjthmpivqgsulwkboec

ufrpkliqjgwxeybmcztasovh
qvkpyghxblewsaitrmzuonjc
giptzywrejquxkoavslcmhb
peaywubjozmcgrihlqsvxktf
lehjpzguiksacobxywtmvrq

egryz
ergyz
yzegr
yfcgzre

j
j
j
p
j

bjt
tbj
tjb
tbj
jbt

cklp
lpck
lckp

fea
eaf

qgm
dz

yri
yi
zypdi

ekwjxhtmgiudpz
xepuhgwjizkdrmt
ezghmliwtxujdpk
wdhxpjizugkemtl

gyokbspj
kbgsopyj
pykhdsjbgio
opjykusbg
jygbsopakc

ixorlekwgnbcjm
lrjkwxgie
wgeikxjrlh
rlkjxipeqgw

ecgmdrykq
myrclqdgek
guqmzyceprkd
dygckwerqm
yrcgkiqempd

u
u

bcwnvl
fcvsib
hcnvb
cpgveoaby
ivbcn

n
n
n

macuqyp
fs

pbout
suota
cuotm
atmuo

nlravibecfj
eilcjafn
aeibjfl
jxfeilauo
jafesdnli

xfwroij
fxwijor
irxjofw
rfjwboxi

dj
dvj
dj
dj

mikhxcqensrodu
imcvkhewgljupsxonq
kceuqxltinhsom
kzqanoemcxhius
vmuoxineqpzhacbks

hklcsoaywpfrdntmu
xirbzckwjvpfygeno

o
to
o

zvirefunh
ezhirnvfu
runifzhev
ezivhnrfu

zfsoducbpai
cupdisobazf
aozbsucfdiypv
bcfazodiups

njfprukxamlg
kpfrjgynulxma
pijflgnuxkram
pkuxalrmjfgn
nkvrlmxustpfjga

dszgm
rsmu

iaw
aiw
wai
aiw
iwa

s
s
s
sl
s

eyavhnk
keov
qeiwfkcgvrpsld
kuvze

a
mh

ilqchdfsog
igscolmdzq

fnyhxmpct
lchdpamfu

vijz
vj

dhpxjrmyuefclvqgni
uicskweohgvfryxmdq
tqgdifymexbwckruvh

c
c
c

lthidumvycszw
cvpqjeuhlwrfyzg

keocuw
uckowe
oekwcu
cwukoe

c
c

lkxjv
jkvxl
vxklj
jkvxlwg
zkxvjly

sqlamxeuhpgwjbdcioy
bumyjxsiqweholpgcda
gecswjlqhadiuboxmpy
syahibgopexwlucdqjm

igebmv
tawqvezdsmpunk
rimocvgje
evmbhc

ykjisvfatux
jfaisyvktux
itksajfxuvy

fclkush
slcykdbgu
fskuchl

xjhulywagzeioq
oejlfsquhbriayxwg
jiexgylwzhuqao
wyxhqljagieou
hwladixguqejyo

sofcbhuwyqtid
icofdwsb
dfwovimbcs
cwibodnsxf

jqnestpyaczfmxhwrbuvldi
mxanrhbfcujvyzditwlo

ntfgivkyszmarc
qrajdhowuvpclbex

kliwy
ukwlryi
ilkyw

pmgltzsk
ljmipztvgow
zltmgup
umztglp
ftzmlpgk

twepi
teq

ohyd
mytjrwk
hfy
exyh
ye

rzsqhtlowavy
twvhzyrjsqaol

yzagcqrjeimwxokh
fmxtiagboleqcwdrhzk
opvemhasrguxkcqzwi

atcpeyosnrjbg
kcesobgua
fagsev

ca
ac

xahmtil
hximtla

hyutnjdrbsmofl
dswjfyothmblrnq

et
te
eqt
tuje

nbhpwzgtrcx
gqcxobhriznw
hwnbugrejxtczs
cujrbxfhnwzg
gcwzhrxndjb

qwrfxhlyzcptvmkdeauigob
zbchavlkmryxiptegwfouqd
cfhuiptgqkoalrewzmvbyxds
hudmwcgbfepyitovkaqzxrl

eysuozkm
ndgloqyv
ignhwrovy

iqufgnvxspdcjtylkbrozh
inuzqktrvcxyhbgfosljdp

qhfknsyeuirzagvcwd
yfcgqnxewlkrsuazhi

lj
jl
lj
lyj
jl

kpholfxewrdt
opdfhtlmkwex
hpwftoxderlk
ylxhwdofnztkpe
rwfpxlhtdkoe

ubml
yvohg
zeasf
plum
qhnjxg

cjgzwmdyuakvixlprhfe
kmplfuxywergchzjvani
xcvlzmewyujgirhpfka
fwhgrxkjcvpeuilzyam

eclsiqp
ivgspoe
scepi
pmiadtskyze

akmdfivwgct
yvgcwakhdimts
lcvgirakwudtp
aftnckwmidgv

zuqblv
blvzqu
uvbqlz
qbuzvl
bzqxvlmu

by
betlcdvry
yb
bxy
gybjx

waoqdxpkmfnyrhjebcuvzs
qprvfczedowxknhausmyjb
cufdqvknwrajzybospmxeh
qkjzybeadvncwhxumpfsro
nwfkjxumpabzodvqychsre

shdfctjrkwbvemoxluyzipnqag
sgbwpeuqcilxojfynmrdhvktaz
lhgkxfwuzbevojmrpnqydsacti
gflnzjasbuyimxqcvwrdpohetk
ynwedhbskjtvoucgapiqlzfxrm

wlmjxp
ylnxoajk
luxjidte
xjrvlcdeu

pv
vbpw
wvuap
kceavp
rdphvoitqf

dlxzwkhtmc
twzhlmkdc
tcylhkdwzm
zwmlkdcth
gdhikmctlwsz

hpekwtlufyragqvb
kbrwatlupqyfvh
ucbvwlhfqatpkry
hlakvyuqrfpwbt
rubvwpfqlatkhy

npxobl
ckuhnplvx

edkpjycofasulrthw
rpuhcdyxlftosewa

stuvhwaexykzdorbfpi
shjuwgpfqmtacvlbirkzd

frph
wo
h
zumtyngcj
pfse

zivsgurp
szirpvg
gikvsprz
zigpvsrk
nvpsgzir

rfimu
hmqrlfxpbgu
nrmoyftu
nmujfr
rfum

bidzwmearovjkgcl
ogdbirkzqmclejvaw
gealcqozmijkbrvdw
gzakwmdbejclrivo
eolwifvgmrbjdazkc

iurfyqgwk
ymkvqfpwrig
aqrfywikg
bfdryxikgnwoq
cjfgkryiuwq

jvb
x

qkxnvfuopdytrzjgbm
bmqkuyarjgtdpfzsnox
obwjxyeqtingzmdrfkplu
gamupstryfokbzqdxnj

ymanp
npfshjya
pundyklatc
ypfanh

garp
grpa
arpg
argp

inedmtpwrvub
vwibertnudmp
idurbepwtmnv

yczoaplwmxibqgsfn
wbiuxyqzpncvgmsl
gpoltrbisqfznwxcymj

a
a
a
a

cgjviyufped
pcuvygzkjid
ptvigyjdcku

u
i
tqa
j
ul

zitbfuer
uzfithernb
uftbzire
uitefbzr

jcwkroamnegxvqsh
kejhanqmvcrxwsog
gaqmkexjvcsnrowh

taegslmuyqcipz
asytxrgdpfbcqliwz
tpgoschavqjlkyzi

oc
oc
oc
co

mrfvjlykquz
fzmvuleykqt
vykmzlgquf
kqfzuvygetml

a
s

ionve
eailo
jiomexwh
beziqpdco
ihtoe

cfjvrqosnwyedaubmhgtlxzk
olxzjfwrcytkbgudasvqhnme
tuwfnckrzsvjgbxdmyhqlaeo
txnydgufbmjaqkrzlwhoevcs
bgakxqmfsdwyjvelntchzour

njvkobzs
bsjvkwn

qmnluxw
ovgtikpdbrya
nchfsjqez

khtdryej
hdrtv
qnaodtm

as
aus

omjaixvgklq
vgkaxjihdrlq
ycxkzatpusiljqgv

jtepylmrqbiwk
xerlpmynqtkfbjwi
timwpbkegljqry
lqijkebmgpwyrt
qrkljpbytemiw

q
xqint
dkqb

trjmdxpoeqcwf
tfedxqcprwom
kmftwxqporncde

fpcmndhr
dzepjngqikcfrh
nhfpcrd

c
c
c
y
c

t
t
ti

tgfspxdy
sytgpfxd

zov
voz
ovz

ic
ieuc

vhesndkizjgwcpobulam
szjymxwopckfqtgdib

jdfzgqsbrmnticl
fbcdgqtznmjri
doitrczjqfbgmn
otzbjfidmnrqcg

cb
bc
cb
cb

aspjvghyurx
vcarwsbh
laeshvzrb
hsrvia

kpxzdhasfmltouvrc
duvpkascromz
vmcskupzorad

pguayqbwm
gpyaqbwum
ywaqgpmbu

ypdlnjse
elskbyz
jesylo
lyse

zlokqmjiurpwgbn
xzvurhgmlkwqnibjpo

wpzenbojcykqxvt
wnyzlbjkeoqtvcpx
itkjzydbpvoxcewnq

gfuvenodsizwmh
hwfuvsntdg

gkibnpalc
inkcgpal
gnpzliakfc

ibektdpuhg
iwbgjke
iycnergfqkbo
egxadvlmbijk

l
yjg
l

ymuoc
oymcu
oymcu
youcm
ycomu

wifoqy
zksfrict
bdpvhuilgejn
acoi
mqi

qrcukhwvzdjilpto
hqrmwkupclvjtizo

gdizlfawobuk
dihqfswcgukzrbla
gmukawbdfizlo

zwdrpv
dzvpwr

ycidkpfrqjelha
pjahykfecdqrli
kfqlajhdepyirc
pkhaceijlqdfry

pwuxbqotey
okbphqutfx
xvsgodubtlpqijr
puoewaxtbmq

qtbaoex
xpoqa
agiweqtop
nozuadmjrq

huvqdaij
fkuvaijdhq

biewrdlzc
rjlcikbzmdwve
leucwfpoizndbxr

avgtnubqcpxrhwdoml
vrkqgyndcmohtupswa

dmjqfesnxyciz
hfzudcjxsmno
mfjhrcsxznd
lcmbjnxzfadrs

tvayrhpqskd
qrtkvhyus
epjsytzhvrqk
yzqohmvtgsrk
hvlysqtwirbk

ieyd
aipeyg

r
rg
rm
r

qcweajhfmlgyzpv
ouqdxmsphkbatenr

fba
kfba
baf

vxpblsyjnrmkai
vpyhagcwqbzxmik
rpbytexdijnfavkom

fpmytnk
cyaw

jhyimdg
mhyij
hmvyij
mihezcovyj
yhmciej

sqfaopkgze
kxsecfphozq
qsotezpfk

ewcvoaurmjhq
cuqvjwreaohm
ewvjmqacuorh
wauhojecqmvrs

lyieuqdjcb
vkpctdmywzsreubn
delchbujy
jbcyegdou
xduayceb

nidxswarcqtk
kciqdarnbewsxt
acqrdkntipxlsw
ikpawtcdsqnrx

gikrfhwltveap
yeplvatowncgxirf
griadtewmvblpf

htjkmzxlvbygcwqioe
jzwtymxvigbheolckq
cxmvjyklobhtwgqzie
teczbxvlmgojqiwkyh
oxvejlbtiqywhzgmkc

jkfapozdwcie
bmushwjgltrn

rpnbxkoij
exjdri
uirjegxsa

zawoncbymgsrhv
dvctxgeusr
cvizgyhlmrwsfp

shnyujedctwfq
yscahxndftreq

xrnysi
itcluvmd
niqwozjber

gjobshlayxvctnfq
ljcxaonvbstqfgyh
ybhxgntqcsvfaojl
rjoxblqavncusgheytf
sncqlvybxfjtghao

uozb
ldewrck
xbg
xhg
z

yubqaznf
imwhrgnkjls

msvgjrnkcloaup
csxjnkgrpiuoveamy
pknvrajmcudswgzo
tnupacsxrgkvmoji
bpnkfarqumsvhcojg

bzvyuenaihfdcgwk
puchyenmzgksrijoa
ugebciktnlzhay

cedfutpnsivjlobrkaxy
denscvpbmlkxaojrfh

vugjrq
jqgtuwcnrv
grvkuqj
gbmvqsyxjueplzirhf
avudnjqgr

vpidajtmgozxwuksh
ughiwmakpjszdtvox
wugipxzdvastkhmj
sxughjakmnwfpdivzt
wimvaupjhgxstkzd

mqsuwhdxpcozfr
rsdwhfpakzxjmo
eysprldfqzowmhx
fodhrtmswxyzp

vsmzfbjhwqxiugtlc
gcqdsfmpletnhbxr

uxbgkfjwesmlchr
feakldxqnpwcjgvrzbhs
hjosrixfmlcgbkew

dszv
zsvd
vsdz
zvds
sdzv

pdw
lxudjpiwz
advnkpqw
hswpdog

gslpira
neuzf

ifjt
tjif
jfit
jitf
ifktj

jrnzb
unkjshpe
njza

ydigxaqm
iaeokqgmyhr

bkxmngtdlyev
nmbuzoveixlprkys

zjloghmtu
ermvzn
qzdncfm
afczxmp

aptscynieqmfgjhbr
bmsirnafyepthgcqj

q
qlr
fq
qk

v
v

ucrmbsozjkfy
buscrmofkzy
uosmfkryzbc
sqirbfzmocuynk
mbucykofrzs

lrp
plz
lrp
lp
lp

yfzmpgcsw
prycgfm
rfcmgpy
scgmyqpf
flcyvpohmgu

g
g
g
e

lxoaibjch
wudyrfvkzn
gtpmkeyqd

zjhlwbtfuvick
wujtvblzchkif

ksdfpvqbtxaluneo
dqofprhnxamskujeb

hacwigyftqblx
xwlqahitbgcyf
ahyxlwgtqifbc

mb
m
mg
m

ecrasdtyljuqimhnwfb
qleiaydjcugrwn
jdyewaqnrcliu

g
lqfio
adhstybz

gryzuxenhlvopbtmfwqcas
yeqzalmogbncxpsfujwh
mflqzhoaupcseygnbwx
myswzuonfqlaxecbhpgj

uwvzati
uzcjvtai
savuizt
atiuzv

cozuin
abuizo
tiozua
wilfzeoqu
roictxuz

gndpkojqu
gunkpsjoa
rtmzjpgkovwxlnuc

lrj
rjl
mrjl

udlpevjgzrfawitqs
qgrtiujslfeovza
surivgtfqjleaz
ezavgjtlfrusiq

g
fx
mf
tx
iyqd

sljgmdztynvrqexhwfi
gvwdyerlqnxthmjifsz
qgmjlfwrxztynivdhse

zkvuir
kvruiz
vriukz
kriumzv
zruikv

zyqgnvda
kdygvqanz
zyagvqdnu
qnwdmlaxgzyfvo
dnzgyavq

o
s
q

cbroy
qiyocmjdt
uyoc

lkqj
kjql
jqlk
ljqk";
    }
}
