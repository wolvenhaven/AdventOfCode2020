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

        public string luggageRulesTest = @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags.";

        public string luggageRules = @"vibrant salmon bags contain 1 vibrant gold bag, 2 wavy aqua bags, 1 dotted crimson bag.
dotted plum bags contain 3 wavy cyan bags.
muted salmon bags contain 2 pale purple bags, 3 dull orange bags, 2 dotted lime bags, 3 clear crimson bags.
wavy green bags contain 1 plaid crimson bag.
light salmon bags contain 3 posh lime bags, 1 plaid plum bag, 3 faded yellow bags, 4 clear fuchsia bags.
dim violet bags contain 4 drab tan bags, 4 drab violet bags, 2 faded coral bags, 4 dark white bags.
dim black bags contain 4 posh lime bags.
drab indigo bags contain 4 light aqua bags, 2 light white bags, 4 clear plum bags.
clear purple bags contain 4 drab olive bags, 2 vibrant chartreuse bags.
wavy indigo bags contain 3 clear maroon bags, 4 striped blue bags, 2 wavy gray bags, 2 dim magenta bags.
drab olive bags contain 2 shiny salmon bags, 4 mirrored white bags, 4 mirrored fuchsia bags.
plaid crimson bags contain 2 dull chartreuse bags, 4 striped maroon bags, 4 dull crimson bags, 4 plaid red bags.
pale lavender bags contain 4 dotted tan bags, 5 striped olive bags.
vibrant maroon bags contain 2 faded plum bags, 4 wavy aqua bags, 5 drab lavender bags, 4 light lavender bags.
wavy coral bags contain 5 drab purple bags.
drab salmon bags contain 4 shiny tan bags, 2 shiny white bags.
light green bags contain 5 dim turquoise bags, 4 striped crimson bags, 5 dim salmon bags, 3 clear gray bags.
dark indigo bags contain 5 shiny crimson bags.
dark blue bags contain 3 drab indigo bags, 2 shiny beige bags, 2 shiny coral bags.
shiny cyan bags contain 2 striped aqua bags, 2 drab turquoise bags, 5 light purple bags.
pale cyan bags contain 2 muted violet bags, 2 clear beige bags, 1 clear indigo bag, 5 striped turquoise bags.
muted lime bags contain 5 drab silver bags.
shiny brown bags contain 4 clear purple bags, 5 striped chartreuse bags, 5 pale lavender bags.
muted purple bags contain 4 dark purple bags, 2 dull crimson bags.
plaid turquoise bags contain 2 clear gray bags, 4 clear magenta bags, 4 dull bronze bags.
clear cyan bags contain 3 dotted plum bags, 3 shiny coral bags.
shiny violet bags contain 3 drab chartreuse bags, 1 pale aqua bag, 3 bright aqua bags.
wavy tan bags contain 5 dark magenta bags, 4 dull beige bags, 1 wavy cyan bag.
mirrored lime bags contain 2 clear plum bags, 3 dark bronze bags, 5 faded turquoise bags, 5 plaid crimson bags.
wavy purple bags contain 3 dark bronze bags, 2 bright bronze bags.
plaid plum bags contain 5 muted tan bags, 1 drab teal bag, 2 dark purple bags, 1 dotted blue bag.
dotted cyan bags contain 4 vibrant fuchsia bags, 3 muted plum bags.
striped white bags contain 3 faded salmon bags, 4 plaid cyan bags, 5 wavy gray bags.
posh black bags contain 2 dotted blue bags, 3 muted crimson bags.
dotted bronze bags contain 2 posh tan bags.
muted gray bags contain 2 posh green bags.
plaid violet bags contain 4 muted orange bags.
muted green bags contain 3 drab silver bags, 2 mirrored maroon bags, 3 dark teal bags.
dotted tan bags contain 3 pale black bags.
dim beige bags contain 4 light plum bags, 4 posh blue bags, 4 dotted purple bags.
posh magenta bags contain 2 clear purple bags, 4 posh aqua bags.
bright coral bags contain 5 light bronze bags, 2 vibrant crimson bags, 4 dark gold bags.
pale bronze bags contain 1 striped orange bag.
dim lime bags contain 3 dim green bags.
plaid green bags contain 2 faded brown bags, 3 faded bronze bags, 3 pale green bags, 5 plaid magenta bags.
vibrant cyan bags contain 5 pale black bags, 5 vibrant violet bags, 1 mirrored red bag.
dotted fuchsia bags contain 3 dull crimson bags, 2 wavy silver bags, 4 muted purple bags.
dim red bags contain 2 clear indigo bags, 5 dotted yellow bags.
faded black bags contain 4 bright fuchsia bags.
faded chartreuse bags contain 4 striped orange bags.
plaid blue bags contain 5 dim gray bags, 2 pale salmon bags, 2 muted orange bags.
plaid teal bags contain 5 bright lavender bags.
drab magenta bags contain 2 dim crimson bags, 1 bright fuchsia bag.
clear violet bags contain 3 mirrored white bags, 5 faded lime bags, 2 light olive bags, 1 dotted turquoise bag.
posh tan bags contain 3 posh orange bags, 1 vibrant purple bag, 4 posh gray bags, 2 mirrored fuchsia bags.
posh red bags contain 5 mirrored red bags.
striped lavender bags contain 5 dotted crimson bags, 1 dotted purple bag.
dull salmon bags contain 1 wavy black bag, 2 dull lime bags, 3 bright plum bags, 2 dark gray bags.
light tan bags contain 3 wavy violet bags, 1 shiny olive bag, 5 bright brown bags.
pale orange bags contain 5 vibrant orange bags, 3 wavy black bags.
mirrored green bags contain 1 dark tan bag.
plaid gray bags contain 4 muted magenta bags.
dim maroon bags contain 3 light magenta bags, 4 dull red bags.
dull cyan bags contain 1 wavy blue bag, 1 dark chartreuse bag.
mirrored blue bags contain 4 dark cyan bags, 4 muted magenta bags, 2 striped olive bags, 1 posh gold bag.
plaid purple bags contain 1 shiny orange bag, 5 plaid coral bags, 4 dim red bags, 5 faded aqua bags.
vibrant magenta bags contain 5 posh aqua bags, 5 shiny chartreuse bags, 4 dark teal bags.
bright indigo bags contain 1 dark bronze bag.
bright yellow bags contain 4 muted lime bags, 1 drab maroon bag.
clear gold bags contain 2 striped blue bags, 3 clear green bags, 4 drab indigo bags.
wavy red bags contain 5 faded fuchsia bags, 5 mirrored indigo bags.
dark coral bags contain 3 drab aqua bags, 5 bright fuchsia bags.
striped teal bags contain 1 clear red bag, 3 drab magenta bags, 4 dim green bags, 2 dark fuchsia bags.
pale salmon bags contain 1 muted gray bag, 4 dotted lavender bags, 3 dark maroon bags, 4 plaid plum bags.
dull plum bags contain 3 dim black bags, 5 shiny aqua bags, 3 pale teal bags, 4 clear purple bags.
plaid indigo bags contain 4 drab maroon bags, 2 shiny chartreuse bags, 4 shiny yellow bags, 1 pale violet bag.
shiny orange bags contain 5 bright silver bags, 2 light olive bags, 5 light beige bags.
dotted salmon bags contain 4 posh chartreuse bags, 4 light crimson bags, 5 muted yellow bags.
vibrant aqua bags contain 2 dull brown bags.
shiny bronze bags contain 1 mirrored teal bag, 2 drab tomato bags.
dark black bags contain 5 muted red bags, 5 mirrored crimson bags.
muted bronze bags contain 3 clear tomato bags, 1 vibrant purple bag.
faded beige bags contain 1 shiny blue bag, 5 plaid lime bags.
pale green bags contain 2 pale crimson bags, 4 muted cyan bags.
vibrant bronze bags contain 1 bright lavender bag.
posh salmon bags contain 1 clear green bag, 2 plaid yellow bags, 3 bright orange bags.
dull yellow bags contain 1 clear plum bag, 2 dim bronze bags.
mirrored indigo bags contain 5 dark tomato bags, 5 pale coral bags, 5 light magenta bags, 5 striped turquoise bags.
muted chartreuse bags contain 3 dark tan bags, 4 dotted teal bags.
drab bronze bags contain 3 pale lavender bags, 1 bright salmon bag, 4 plaid red bags.
dim cyan bags contain 1 bright plum bag.
drab purple bags contain 1 dim fuchsia bag, 4 mirrored turquoise bags, 5 striped blue bags.
pale violet bags contain 5 posh brown bags, 5 striped plum bags, 1 dotted indigo bag.
wavy maroon bags contain 3 shiny blue bags, 3 wavy cyan bags, 1 faded purple bag, 4 posh lime bags.
vibrant coral bags contain 3 shiny turquoise bags, 4 mirrored maroon bags.
vibrant lavender bags contain 2 drab turquoise bags, 2 clear red bags.
striped fuchsia bags contain 4 dotted tan bags, 4 posh silver bags, 4 clear maroon bags, 5 wavy fuchsia bags.
muted lavender bags contain 2 pale aqua bags, 2 bright green bags, 5 posh beige bags.
posh tomato bags contain 2 vibrant bronze bags, 3 light brown bags, 5 posh indigo bags.
dull lavender bags contain 2 wavy olive bags.
mirrored violet bags contain 5 wavy violet bags, 2 posh cyan bags, 2 dull olive bags, 3 drab yellow bags.
mirrored chartreuse bags contain 2 shiny salmon bags, 5 dark purple bags, 2 posh lime bags.
dim brown bags contain 4 clear red bags, 1 drab blue bag, 1 pale silver bag, 5 dark gray bags.
striped magenta bags contain 1 light orange bag, 4 muted beige bags.
light red bags contain 3 shiny yellow bags, 3 faded tan bags, 3 vibrant lime bags, 3 muted coral bags.
muted olive bags contain 4 drab coral bags, 5 light salmon bags, 1 vibrant violet bag.
clear silver bags contain 1 posh aqua bag, 1 drab teal bag, 4 dark orange bags.
faded orange bags contain 4 vibrant purple bags, 4 wavy cyan bags, 1 drab brown bag.
mirrored crimson bags contain 5 light aqua bags, 1 wavy olive bag, 2 vibrant lime bags.
shiny plum bags contain 2 shiny maroon bags, 3 dark red bags.
faded green bags contain 3 striped turquoise bags.
bright orange bags contain 1 dull crimson bag, 1 pale lavender bag, 5 shiny aqua bags.
dim gray bags contain 2 drab indigo bags, 5 dim turquoise bags.
mirrored plum bags contain 1 vibrant red bag, 4 dotted purple bags.
posh gold bags contain 4 bright red bags.
posh silver bags contain 3 drab coral bags, 1 faded tan bag, 1 bright silver bag, 1 shiny blue bag.
dull lime bags contain 5 muted tan bags, 4 mirrored cyan bags.
faded turquoise bags contain 2 pale teal bags, 2 bright green bags.
bright salmon bags contain 1 dim white bag, 2 clear tomato bags, 1 bright aqua bag.
dim gold bags contain 3 mirrored turquoise bags, 5 wavy tomato bags.
dull fuchsia bags contain 2 pale beige bags, 1 dotted yellow bag.
dark beige bags contain 2 pale magenta bags.
dotted maroon bags contain 2 dark tomato bags, 2 light gray bags, 3 faded teal bags, 1 clear gray bag.
muted white bags contain 3 dull turquoise bags, 5 dark bronze bags, 1 light olive bag, 3 clear bronze bags.
faded blue bags contain 1 dark chartreuse bag, 3 pale aqua bags, 5 faded crimson bags.
clear aqua bags contain 3 vibrant olive bags, 5 clear crimson bags.
faded cyan bags contain 1 vibrant blue bag, 1 light magenta bag.
shiny aqua bags contain 1 clear green bag.
bright gray bags contain 2 dim fuchsia bags, 1 striped chartreuse bag, 2 clear aqua bags, 2 dull olive bags.
bright white bags contain 2 light purple bags, 5 bright aqua bags.
bright lime bags contain 1 pale orange bag, 5 plaid magenta bags, 4 mirrored maroon bags.
dark lavender bags contain 5 mirrored bronze bags, 4 dotted aqua bags.
striped chartreuse bags contain 3 striped indigo bags, 2 faded plum bags, 4 clear gray bags.
muted magenta bags contain 3 clear red bags, 3 dull crimson bags, 1 clear aqua bag, 4 faded tomato bags.
clear magenta bags contain 2 striped cyan bags, 5 vibrant lime bags, 4 striped salmon bags.
pale yellow bags contain 3 faded fuchsia bags, 2 dotted lime bags, 5 pale gold bags, 1 plaid tomato bag.
dull teal bags contain 4 dim green bags, 1 drab maroon bag, 2 dim crimson bags.
pale brown bags contain 5 drab orange bags, 2 dotted purple bags, 3 plaid olive bags, 3 pale black bags.
posh blue bags contain 4 faded purple bags, 4 drab turquoise bags.
pale olive bags contain 5 muted silver bags, 3 mirrored plum bags, 4 vibrant lime bags, 5 striped olive bags.
plaid black bags contain 3 posh yellow bags.
striped tomato bags contain 4 faded blue bags, 2 shiny magenta bags.
wavy tomato bags contain 1 pale gold bag, 2 dim magenta bags.
faded plum bags contain 3 light violet bags, 3 posh beige bags, 3 striped aqua bags, 4 dim magenta bags.
vibrant turquoise bags contain 3 muted silver bags, 5 dotted black bags.
dull white bags contain 5 dim gray bags, 1 faded crimson bag.
faded purple bags contain 1 vibrant orange bag, 4 pale crimson bags, 5 shiny blue bags, 1 light gold bag.
clear white bags contain 1 striped orange bag, 3 pale coral bags, 5 plaid chartreuse bags.
striped maroon bags contain 2 wavy olive bags.
light tomato bags contain 2 pale crimson bags, 3 bright fuchsia bags, 2 pale salmon bags, 3 pale olive bags.
drab tomato bags contain 1 pale olive bag.
dark aqua bags contain 1 shiny magenta bag, 4 faded lime bags, 4 faded gold bags.
plaid bronze bags contain 2 pale purple bags.
dark plum bags contain 3 wavy brown bags, 1 bright salmon bag.
dark purple bags contain 4 dotted red bags.
light teal bags contain 1 vibrant indigo bag, 5 wavy olive bags, 4 clear maroon bags, 1 light silver bag.
drab fuchsia bags contain 3 faded turquoise bags, 5 dim yellow bags.
light turquoise bags contain 1 dotted blue bag, 4 mirrored tomato bags.
clear maroon bags contain 4 mirrored green bags.
posh maroon bags contain 3 dim black bags, 3 bright gold bags, 3 mirrored white bags, 1 clear lavender bag.
dotted blue bags contain 2 wavy maroon bags.
bright tan bags contain 4 faded turquoise bags, 5 drab coral bags, 5 dull red bags, 2 dim gray bags.
dark salmon bags contain 4 clear fuchsia bags, 5 mirrored red bags.
mirrored fuchsia bags contain 4 bright tomato bags, 3 vibrant orange bags.
vibrant green bags contain 1 clear lavender bag.
dim white bags contain 5 dull red bags.
light white bags contain 3 dark purple bags, 1 mirrored fuchsia bag, 1 plaid gold bag, 1 posh lime bag.
dark turquoise bags contain 3 striped green bags, 1 dull gold bag, 2 pale gray bags.
light purple bags contain 5 muted brown bags, 5 muted purple bags, 4 dull yellow bags, 5 vibrant gold bags.
posh lavender bags contain 5 posh yellow bags, 4 plaid plum bags, 1 dark fuchsia bag, 1 bright maroon bag.
posh crimson bags contain 1 vibrant gold bag, 5 clear green bags, 2 posh chartreuse bags.
wavy lime bags contain 5 mirrored beige bags.
wavy black bags contain 1 plaid orange bag, 4 shiny green bags, 3 shiny blue bags, 4 muted red bags.
muted red bags contain 4 vibrant lime bags, 2 drab black bags, 4 vibrant red bags, 5 faded beige bags.
vibrant gold bags contain 2 bright silver bags, 4 faded teal bags, 2 vibrant orange bags, 3 striped salmon bags.
shiny crimson bags contain 2 bright yellow bags.
muted turquoise bags contain 5 bright plum bags.
posh orange bags contain 4 vibrant yellow bags, 5 clear crimson bags.
wavy aqua bags contain 5 shiny green bags, 5 bright fuchsia bags, 4 muted fuchsia bags.
clear green bags contain 4 dotted plum bags, 2 vibrant olive bags, 5 pale beige bags.
pale aqua bags contain 3 dark tomato bags, 5 posh lime bags.
drab maroon bags contain 5 bright magenta bags, 2 bright plum bags, 5 clear green bags, 3 faded tomato bags.
vibrant plum bags contain 3 light crimson bags, 5 dotted silver bags, 5 mirrored red bags, 1 dotted turquoise bag.
posh yellow bags contain 5 plaid lavender bags, 5 dim tomato bags.
faded brown bags contain 1 striped orange bag, 5 wavy green bags.
drab cyan bags contain 4 faded teal bags, 3 vibrant aqua bags, 2 light chartreuse bags, 3 dark orange bags.
dark lime bags contain 4 vibrant blue bags.
faded coral bags contain 4 wavy green bags, 4 mirrored gold bags, 3 striped fuchsia bags, 1 pale fuchsia bag.
dark orange bags contain 1 dotted red bag, 2 vibrant red bags.
wavy magenta bags contain 3 dull chartreuse bags, 2 dim maroon bags, 2 clear maroon bags.
plaid coral bags contain 4 drab tan bags, 1 pale tan bag.
mirrored salmon bags contain 1 muted bronze bag, 5 muted purple bags.
dim tomato bags contain 2 drab silver bags, 4 mirrored purple bags, 1 dull olive bag, 5 dotted purple bags.
wavy gold bags contain 3 dark crimson bags, 1 dim white bag.
light fuchsia bags contain 3 mirrored green bags, 2 wavy fuchsia bags.
pale tomato bags contain 4 clear purple bags, 5 faded brown bags, 4 light coral bags.
faded yellow bags contain 5 wavy olive bags, 2 pale lavender bags, 4 bright plum bags.
light violet bags contain 1 dotted red bag, 4 dim aqua bags.
posh lime bags contain 2 pale crimson bags, 1 pale gold bag, 1 shiny blue bag, 4 muted gray bags.
mirrored silver bags contain 4 striped bronze bags, 3 faded salmon bags, 3 drab green bags, 4 striped green bags.
dark green bags contain 5 striped maroon bags, 3 dim olive bags, 4 vibrant chartreuse bags, 5 dim white bags.
mirrored olive bags contain 2 dotted red bags, 5 dim white bags.
dark teal bags contain 3 wavy olive bags, 3 pale crimson bags.
pale tan bags contain 2 dark orange bags, 5 bright plum bags, 4 pale crimson bags.
wavy plum bags contain 3 dull lime bags.
light indigo bags contain 5 dark magenta bags.
drab lime bags contain 1 bright fuchsia bag, 4 wavy brown bags.
drab tan bags contain 3 bright tomato bags, 1 muted green bag.
vibrant indigo bags contain 5 dull chartreuse bags, 5 clear aqua bags.
dark bronze bags contain 3 dull red bags, 3 mirrored maroon bags, 1 muted green bag.
shiny red bags contain 2 dark bronze bags, 4 faded magenta bags, 5 dull teal bags.
shiny black bags contain 3 vibrant olive bags, 2 plaid lime bags, 5 shiny gold bags, 2 dotted plum bags.
light gold bags contain 5 vibrant olive bags.
light plum bags contain 5 clear gray bags, 5 dotted chartreuse bags, 4 plaid red bags, 1 plaid lime bag.
bright violet bags contain 4 bright maroon bags, 5 posh red bags, 2 faded olive bags, 4 dim gray bags.
faded red bags contain 4 drab maroon bags, 4 vibrant violet bags, 1 faded purple bag, 2 dotted black bags.
muted orange bags contain 4 plaid chartreuse bags, 5 muted lavender bags, 2 faded purple bags.
clear coral bags contain 2 drab teal bags, 5 bright turquoise bags.
wavy orange bags contain 4 muted cyan bags, 3 light indigo bags, 5 bright black bags, 5 light salmon bags.
faded fuchsia bags contain 3 pale gold bags, 3 faded salmon bags, 4 pale red bags.
light brown bags contain 4 pale silver bags, 4 clear tan bags.
shiny gray bags contain 3 muted teal bags, 1 bright purple bag, 2 bright olive bags, 4 mirrored green bags.
bright brown bags contain 2 dark teal bags, 5 light plum bags, 2 plaid olive bags, 5 dark chartreuse bags.
mirrored white bags contain 1 wavy gray bag, 3 bright tomato bags, 1 muted silver bag, 4 striped olive bags.
pale magenta bags contain 1 clear gray bag, 1 muted gray bag, 1 wavy cyan bag, 4 dull brown bags.
bright magenta bags contain 2 muted tan bags, 1 pale gold bag, 2 wavy cyan bags, 4 vibrant orange bags.
clear teal bags contain 1 dark teal bag, 2 vibrant lime bags.
light orange bags contain 3 light gold bags, 4 clear plum bags, 4 dotted indigo bags.
plaid cyan bags contain 1 pale magenta bag.
wavy chartreuse bags contain 2 posh green bags, 5 dotted purple bags, 2 dark tomato bags, 3 muted gray bags.
light coral bags contain 5 clear gray bags, 2 posh purple bags, 2 mirrored violet bags.
dull violet bags contain 3 dotted blue bags, 5 mirrored tomato bags, 1 dull chartreuse bag, 2 posh beige bags.
bright tomato bags contain 3 vibrant red bags, 3 muted gray bags.
mirrored magenta bags contain 4 wavy brown bags.
muted indigo bags contain 4 wavy chartreuse bags, 3 vibrant indigo bags, 2 posh magenta bags, 1 plaid crimson bag.
bright maroon bags contain 2 dull violet bags, 2 faded tan bags, 3 striped gray bags, 5 pale magenta bags.
dark tomato bags contain no other bags.
pale fuchsia bags contain 3 drab silver bags, 4 faded purple bags, 2 mirrored cyan bags, 5 dark bronze bags.
dull black bags contain 1 dull indigo bag, 1 wavy brown bag, 5 striped gray bags.
pale white bags contain 3 light gray bags, 2 plaid lavender bags, 1 wavy maroon bag.
shiny turquoise bags contain 4 pale red bags.
drab brown bags contain 5 mirrored plum bags, 4 dotted red bags.
bright green bags contain 1 dull lime bag, 2 clear lavender bags.
wavy blue bags contain 4 dotted purple bags.
muted aqua bags contain 5 faded plum bags, 3 plaid plum bags, 4 dotted tan bags, 1 clear gray bag.
clear yellow bags contain 4 dotted indigo bags, 3 vibrant aqua bags, 4 vibrant orange bags.
mirrored gray bags contain 4 shiny crimson bags, 2 mirrored coral bags, 1 dotted tan bag, 4 posh cyan bags.
dark maroon bags contain 1 dark salmon bag, 3 muted coral bags.
posh plum bags contain 1 mirrored bronze bag, 4 plaid purple bags, 3 vibrant white bags.
bright teal bags contain 2 pale aqua bags, 1 mirrored black bag.
wavy teal bags contain 5 plaid tan bags, 3 dull black bags, 1 bright teal bag, 3 clear teal bags.
dotted magenta bags contain 1 plaid plum bag, 5 plaid salmon bags, 3 light gold bags.
faded tomato bags contain 1 dark bronze bag, 2 faded purple bags, 4 vibrant red bags, 4 pale lavender bags.
dull blue bags contain 3 dotted bronze bags, 2 shiny olive bags, 3 muted gold bags.
posh aqua bags contain 5 vibrant orange bags, 1 vibrant olive bag.
mirrored black bags contain 3 dark teal bags, 4 plaid chartreuse bags, 2 light salmon bags, 2 vibrant white bags.
wavy violet bags contain 5 vibrant indigo bags.
vibrant blue bags contain 4 shiny olive bags, 4 light olive bags, 2 muted green bags.
dotted green bags contain 3 shiny violet bags, 3 posh black bags, 3 dark lime bags.
wavy cyan bags contain 2 muted gray bags, 3 vibrant olive bags, 4 striped olive bags, 4 drab silver bags.
faded maroon bags contain 5 bright yellow bags, 2 bright tomato bags, 5 mirrored magenta bags.
dull olive bags contain 1 bright plum bag, 2 pale crimson bags.
clear lime bags contain 5 striped blue bags, 5 wavy blue bags, 3 drab tan bags, 1 shiny olive bag.
striped yellow bags contain 1 mirrored red bag.
plaid magenta bags contain 2 clear yellow bags, 1 pale coral bag, 3 muted bronze bags.
light lime bags contain 1 dim turquoise bag.
striped brown bags contain 3 mirrored brown bags, 4 clear cyan bags, 5 bright white bags, 1 muted maroon bag.
dotted indigo bags contain 3 light olive bags, 1 dull chartreuse bag.
shiny tan bags contain 2 dull lime bags, 5 shiny black bags, 5 dull teal bags.
clear olive bags contain 5 drab coral bags, 4 striped aqua bags, 4 dotted lavender bags.
plaid chartreuse bags contain 1 plaid red bag, 4 faded tomato bags.
dotted olive bags contain 2 dull yellow bags.
faded lime bags contain 5 dotted aqua bags, 4 shiny silver bags, 4 muted white bags.
vibrant silver bags contain 4 dotted teal bags, 3 posh olive bags.
striped beige bags contain 2 vibrant white bags, 3 dark gold bags, 4 posh violet bags, 4 bright chartreuse bags.
dim plum bags contain 2 striped indigo bags, 2 vibrant gold bags.
clear crimson bags contain 5 vibrant red bags.
plaid maroon bags contain 4 clear crimson bags.
drab coral bags contain 2 plaid plum bags.
dull bronze bags contain 4 pale black bags, 1 dull tan bag, 5 dull cyan bags, 4 pale lavender bags.
wavy bronze bags contain 4 posh coral bags, 2 bright silver bags.
dull aqua bags contain 3 dotted orange bags, 3 pale teal bags.
muted plum bags contain 1 light blue bag, 2 muted maroon bags, 4 dull olive bags.
vibrant tan bags contain 4 drab teal bags.
dull tomato bags contain 5 dull white bags.
muted yellow bags contain 3 dark yellow bags, 5 faded beige bags.
shiny white bags contain 4 bright silver bags.
muted crimson bags contain 1 clear maroon bag.
muted violet bags contain 3 dotted yellow bags, 1 light indigo bag, 4 mirrored black bags, 5 drab lime bags.
posh white bags contain 3 faded brown bags, 2 dull yellow bags.
wavy crimson bags contain 3 shiny black bags, 2 dotted blue bags, 4 dark maroon bags.
clear salmon bags contain 1 mirrored magenta bag, 4 bright chartreuse bags, 5 vibrant black bags, 2 vibrant chartreuse bags.
pale teal bags contain 5 mirrored white bags, 2 plaid orange bags, 4 muted lime bags.
light aqua bags contain 2 shiny salmon bags, 3 dark tomato bags, 1 mirrored purple bag.
clear beige bags contain 1 muted crimson bag.
vibrant olive bags contain 5 dark tomato bags, 1 pale gold bag, 4 muted tan bags.
plaid brown bags contain 3 mirrored lavender bags, 1 muted crimson bag, 3 muted green bags, 1 bright lavender bag.
dim magenta bags contain 4 pale fuchsia bags, 3 drab black bags, 4 plaid orange bags.
bright purple bags contain 3 muted gray bags, 3 pale coral bags.
posh indigo bags contain 2 bright beige bags, 2 dim tomato bags.
drab lavender bags contain 2 dotted chartreuse bags, 1 posh green bag, 3 light silver bags, 1 dotted black bag.
pale crimson bags contain no other bags.
posh gray bags contain 1 muted green bag.
shiny lime bags contain 3 mirrored maroon bags, 1 posh crimson bag, 4 mirrored orange bags, 2 posh olive bags.
muted beige bags contain 1 posh tan bag, 3 posh olive bags, 1 faded white bag, 2 posh green bags.
light black bags contain 3 striped green bags, 2 pale salmon bags, 3 muted crimson bags.
dark gold bags contain 5 striped maroon bags, 2 pale fuchsia bags, 3 light gold bags.
light bronze bags contain 2 clear purple bags, 4 dim crimson bags.
muted blue bags contain 1 faded gray bag, 4 muted salmon bags, 5 dull bronze bags.
vibrant orange bags contain no other bags.
dim lavender bags contain 1 vibrant indigo bag.
posh fuchsia bags contain 3 clear fuchsia bags, 2 shiny green bags, 3 plaid plum bags.
dim tan bags contain 5 pale plum bags, 3 posh gray bags, 1 clear yellow bag.
pale lime bags contain no other bags.
striped blue bags contain 5 pale black bags.
shiny tomato bags contain 1 dim fuchsia bag, 5 faded blue bags, 3 muted brown bags, 3 mirrored salmon bags.
dotted orange bags contain 4 bright tomato bags, 1 light silver bag.
muted tan bags contain no other bags.
pale black bags contain 2 dull brown bags, 4 mirrored chartreuse bags, 2 dim aqua bags.
shiny purple bags contain 3 dotted indigo bags, 5 vibrant gold bags, 2 light chartreuse bags, 4 clear magenta bags.
dull brown bags contain 2 bright beige bags, 4 vibrant orange bags, 2 bright tomato bags, 4 clear lavender bags.
plaid aqua bags contain 3 plaid indigo bags.
dark olive bags contain 1 pale plum bag, 4 dim maroon bags.
dark silver bags contain 3 shiny blue bags, 2 muted gray bags, 4 drab coral bags.
clear turquoise bags contain 5 light violet bags, 3 drab yellow bags.
wavy brown bags contain 3 shiny coral bags, 3 shiny salmon bags, 1 drab magenta bag.
dim indigo bags contain 5 bright green bags.
mirrored gold bags contain 1 plaid magenta bag, 2 plaid gold bags, 4 light turquoise bags.
drab red bags contain 3 mirrored bronze bags.
faded bronze bags contain 1 vibrant aqua bag, 2 clear tomato bags, 2 dull tan bags.
bright lavender bags contain 4 drab coral bags, 1 bright green bag.
wavy lavender bags contain 2 wavy green bags, 4 drab silver bags, 5 light turquoise bags.
wavy salmon bags contain 2 dotted gray bags, 4 bright chartreuse bags, 4 striped gray bags.
dotted yellow bags contain 4 dark salmon bags, 1 posh tan bag, 4 drab tomato bags, 4 vibrant chartreuse bags.
dull turquoise bags contain 5 drab silver bags, 1 dark orange bag.
pale gray bags contain 4 dull aqua bags, 4 faded gold bags, 2 mirrored orange bags, 2 dim magenta bags.
dark red bags contain 2 bright gray bags, 4 bright black bags.
dim fuchsia bags contain 3 bright magenta bags, 5 pale crimson bags.
vibrant lime bags contain 2 wavy maroon bags, 2 pale magenta bags, 4 pale crimson bags, 3 drab orange bags.
bright bronze bags contain 4 vibrant black bags, 3 drab fuchsia bags, 3 striped cyan bags, 3 dotted blue bags.
muted coral bags contain 3 wavy white bags, 1 plaid tan bag.
wavy white bags contain 2 drab maroon bags.
pale coral bags contain 3 dotted bronze bags, 1 dull gold bag.
drab white bags contain 3 drab silver bags, 3 bright tomato bags, 1 bright silver bag.
light olive bags contain 3 muted tan bags, 2 mirrored tomato bags.
mirrored tomato bags contain 2 dark tomato bags, 3 shiny gold bags.
light crimson bags contain 4 clear magenta bags, 2 plaid coral bags, 5 dull chartreuse bags, 5 dark teal bags.
bright cyan bags contain 1 clear chartreuse bag, 1 striped brown bag, 5 light tomato bags, 4 dark coral bags.
vibrant fuchsia bags contain 3 dull white bags, 1 dim purple bag, 5 shiny yellow bags.
drab gold bags contain 5 wavy chartreuse bags.
plaid yellow bags contain 4 faded plum bags, 1 faded indigo bag, 2 drab purple bags, 1 light purple bag.
bright black bags contain 2 clear yellow bags, 1 dotted red bag, 4 dim white bags.
pale maroon bags contain 2 vibrant tomato bags, 3 mirrored tomato bags.
wavy gray bags contain 2 wavy cyan bags, 2 dark tomato bags, 4 vibrant orange bags, 5 pale silver bags.
faded salmon bags contain 4 bright plum bags.
shiny teal bags contain 4 dark magenta bags.
dim bronze bags contain 5 striped olive bags, 5 dotted plum bags, 4 dark purple bags.
dotted lavender bags contain 4 striped indigo bags, 2 mirrored red bags, 2 bright chartreuse bags, 4 bright teal bags.
plaid beige bags contain 4 vibrant green bags, 3 striped violet bags, 5 vibrant blue bags.
dull purple bags contain 1 dark beige bag, 1 drab silver bag, 4 faded fuchsia bags, 2 vibrant olive bags.
bright olive bags contain 3 faded salmon bags, 1 wavy magenta bag, 5 dim yellow bags.
mirrored maroon bags contain 3 bright magenta bags, 5 pale lime bags, 3 striped olive bags.
clear brown bags contain 2 mirrored orange bags, 5 bright cyan bags.
drab teal bags contain 3 dull olive bags.
clear red bags contain 1 bright maroon bag.
vibrant black bags contain 4 pale fuchsia bags, 3 clear lavender bags, 2 shiny blue bags, 3 dotted blue bags.
faded white bags contain 3 wavy coral bags, 4 faded yellow bags, 5 shiny olive bags, 1 plaid orange bag.
dotted aqua bags contain 1 wavy white bag, 3 dotted blue bags, 5 pale lavender bags, 4 clear aqua bags.
pale blue bags contain 3 dim salmon bags, 3 muted cyan bags, 5 pale fuchsia bags.
dim turquoise bags contain 4 vibrant chartreuse bags, 2 dark silver bags, 3 pale gold bags.
dull magenta bags contain 3 muted salmon bags, 4 dotted gray bags, 3 light salmon bags.
dotted coral bags contain 2 mirrored tomato bags, 1 vibrant teal bag, 3 dull crimson bags.
dull beige bags contain 2 faded fuchsia bags.
shiny gold bags contain 4 bright beige bags, 3 dull crimson bags, 4 mirrored maroon bags, 3 bright tomato bags.
pale indigo bags contain 2 dotted teal bags, 3 faded teal bags, 4 wavy indigo bags.
shiny magenta bags contain 5 bright tomato bags, 5 dull lime bags, 5 mirrored bronze bags, 2 dim black bags.
muted cyan bags contain 2 dark bronze bags, 5 drab silver bags, 4 dotted chartreuse bags.
plaid orange bags contain 4 light plum bags, 5 shiny salmon bags, 5 posh beige bags.
shiny green bags contain 5 dotted tan bags, 5 mirrored olive bags, 1 dark teal bag.
dull maroon bags contain 1 striped black bag, 4 clear green bags.
drab aqua bags contain 1 striped indigo bag, 3 vibrant white bags.
bright gold bags contain 4 mirrored beige bags, 4 mirrored yellow bags.
plaid tan bags contain 5 shiny aqua bags.
striped plum bags contain 4 clear magenta bags, 2 dark gold bags.
vibrant teal bags contain 1 dim aqua bag, 4 vibrant violet bags, 3 plaid olive bags, 1 mirrored olive bag.
posh bronze bags contain 5 dark tomato bags, 5 shiny silver bags.
dim orange bags contain 4 dull salmon bags.
striped indigo bags contain 4 drab magenta bags.
vibrant yellow bags contain 4 drab olive bags, 4 wavy olive bags, 2 dark teal bags, 2 faded purple bags.
striped purple bags contain 5 pale red bags.
dim coral bags contain 1 plaid maroon bag, 2 pale magenta bags, 1 pale indigo bag, 2 dotted turquoise bags.
muted silver bags contain 4 mirrored turquoise bags.
posh cyan bags contain 3 dotted purple bags.
plaid lavender bags contain 3 muted gray bags, 1 light plum bag.
faded tan bags contain 1 mirrored cyan bag, 2 plaid crimson bags, 5 mirrored maroon bags.
clear lavender bags contain 4 pale gold bags, 1 posh lime bag, 4 pale crimson bags.
dull gray bags contain 5 shiny crimson bags, 5 wavy cyan bags, 3 posh lavender bags.
dull green bags contain 1 faded bronze bag, 3 vibrant indigo bags, 2 muted fuchsia bags, 4 dotted silver bags.
dark magenta bags contain 3 wavy white bags, 3 plaid plum bags, 4 wavy lavender bags, 3 drab magenta bags.
plaid red bags contain 1 bright turquoise bag.
dull coral bags contain 4 clear tomato bags.
posh turquoise bags contain 5 dull gold bags, 4 mirrored chartreuse bags.
drab crimson bags contain 2 dull tomato bags, 5 posh orange bags, 5 shiny violet bags.
clear tan bags contain 1 pale fuchsia bag, 4 light aqua bags, 3 shiny blue bags, 3 bright turquoise bags.
dotted brown bags contain 4 drab magenta bags, 5 plaid crimson bags, 2 posh beige bags.
light silver bags contain 3 mirrored green bags, 5 mirrored maroon bags, 5 shiny blue bags.
dotted gold bags contain 2 dim magenta bags.
drab yellow bags contain 5 pale purple bags.
faded lavender bags contain 5 muted cyan bags.
vibrant beige bags contain 4 clear turquoise bags, 2 dark fuchsia bags, 1 pale gray bag, 5 dim beige bags.
clear fuchsia bags contain 1 pale fuchsia bag, 1 wavy turquoise bag, 5 faded gray bags.
shiny chartreuse bags contain 4 vibrant green bags, 1 dotted teal bag.
dim purple bags contain 1 bright turquoise bag.
clear indigo bags contain 4 light white bags, 3 vibrant orange bags.
wavy turquoise bags contain 5 bright magenta bags.
vibrant chartreuse bags contain 4 mirrored chartreuse bags, 2 muted tan bags, 2 plaid lime bags, 3 striped olive bags.
dark chartreuse bags contain 5 shiny blue bags.
clear plum bags contain 3 pale lime bags.
dotted tomato bags contain 5 bright red bags, 2 bright olive bags, 5 drab silver bags, 4 clear magenta bags.
mirrored beige bags contain 4 light violet bags, 5 mirrored salmon bags, 4 dim yellow bags, 5 bright yellow bags.
posh teal bags contain 2 plaid turquoise bags, 3 pale salmon bags, 1 striped plum bag.
dull chartreuse bags contain 5 pale lavender bags, 1 bright turquoise bag, 3 pale beige bags.
mirrored lavender bags contain 4 vibrant tomato bags, 2 plaid tan bags, 5 bright magenta bags.
dark gray bags contain 5 wavy turquoise bags, 4 wavy gray bags, 4 dark bronze bags, 4 pale aqua bags.
dark white bags contain 4 clear maroon bags, 2 vibrant olive bags, 1 dull lime bag, 1 faded lime bag.
dull indigo bags contain 4 clear fuchsia bags, 3 dotted tan bags, 1 plaid cyan bag.
striped tan bags contain 3 pale brown bags.
dull gold bags contain 2 dark yellow bags, 3 dull olive bags.
light lavender bags contain 2 plaid red bags, 5 dotted purple bags, 1 bright beige bag, 3 pale beige bags.
faded teal bags contain 4 mirrored olive bags.
plaid salmon bags contain 1 dark bronze bag, 5 pale yellow bags, 1 striped cyan bag, 2 muted cyan bags.
dotted purple bags contain 1 bright turquoise bag, 1 posh green bag.
dull silver bags contain 3 striped salmon bags, 4 posh violet bags, 4 striped orange bags.
drab chartreuse bags contain 4 pale lavender bags.
striped coral bags contain 5 bright gray bags, 4 dark teal bags, 5 dotted purple bags.
wavy olive bags contain no other bags.
plaid olive bags contain 1 pale black bag, 3 clear plum bags.
drab black bags contain 3 striped olive bags, 2 mirrored chartreuse bags, 5 pale silver bags.
striped lime bags contain 3 dark chartreuse bags, 5 pale silver bags, 2 plaid crimson bags, 4 clear fuchsia bags.
drab beige bags contain 4 dim black bags, 4 striped black bags, 4 dull crimson bags, 5 dark gray bags.
muted tomato bags contain 3 light bronze bags, 3 pale salmon bags, 2 vibrant chartreuse bags.
bright fuchsia bags contain 5 drab orange bags, 3 pale black bags, 3 mirrored white bags, 5 faded tomato bags.
vibrant gray bags contain 4 posh lime bags, 2 dark purple bags, 4 clear aqua bags.
shiny yellow bags contain 5 bright beige bags, 2 vibrant red bags, 5 dim yellow bags, 2 vibrant yellow bags.
posh coral bags contain 5 drab indigo bags.
muted fuchsia bags contain 5 shiny silver bags, 2 dotted salmon bags, 1 muted tan bag.
muted brown bags contain 4 clear maroon bags, 5 dim purple bags, 4 wavy maroon bags, 2 muted red bags.
posh chartreuse bags contain 5 muted tan bags, 3 drab teal bags.
vibrant brown bags contain 1 wavy bronze bag, 5 bright red bags, 4 muted fuchsia bags, 4 clear fuchsia bags.
posh purple bags contain 2 drab turquoise bags, 5 striped blue bags, 1 muted cyan bag.
plaid lime bags contain 3 muted gray bags, 5 vibrant red bags, 1 wavy gray bag, 1 pale silver bag.
posh violet bags contain 2 faded crimson bags, 1 shiny olive bag, 3 bright magenta bags, 1 drab silver bag.
striped gold bags contain 5 faded salmon bags, 2 drab bronze bags, 2 dark plum bags.
striped gray bags contain 2 mirrored crimson bags, 5 faded beige bags, 1 dull red bag.
dim blue bags contain 2 dark coral bags, 3 dim yellow bags, 1 dull salmon bag.
bright silver bags contain 2 mirrored tomato bags, 3 bright plum bags, 4 pale lavender bags, 1 clear tomato bag.
striped red bags contain 4 light yellow bags, 5 mirrored white bags, 5 plaid gold bags.
shiny maroon bags contain 3 wavy cyan bags, 1 mirrored tomato bag, 1 mirrored coral bag.
mirrored brown bags contain 2 mirrored olive bags, 3 mirrored green bags, 1 dim tomato bag.
striped olive bags contain no other bags.
striped violet bags contain 5 bright tomato bags.
mirrored aqua bags contain 4 dark gray bags, 5 shiny blue bags, 2 pale silver bags.
plaid white bags contain 3 dim maroon bags, 2 dim tan bags.
drab orange bags contain 5 striped olive bags.
dark brown bags contain 2 mirrored bronze bags, 5 clear maroon bags, 2 dull lime bags.
dotted silver bags contain 1 dark gold bag, 1 drab black bag, 3 pale aqua bags.
pale plum bags contain 5 striped maroon bags, 5 dotted purple bags, 4 shiny magenta bags.
faded indigo bags contain 1 posh cyan bag, 5 bright green bags.
mirrored teal bags contain 3 muted indigo bags, 4 clear fuchsia bags, 4 vibrant teal bags, 5 drab violet bags.
shiny lavender bags contain 5 striped beige bags, 2 dull magenta bags, 4 clear tan bags.
pale beige bags contain 5 mirrored maroon bags.
striped bronze bags contain 1 pale orange bag, 5 shiny cyan bags, 5 plaid purple bags, 1 vibrant chartreuse bag.
faded gold bags contain 3 pale brown bags, 2 dull violet bags, 2 clear maroon bags, 4 dull lime bags.
clear tomato bags contain 4 vibrant orange bags, 3 bright tomato bags, 3 wavy chartreuse bags, 5 wavy olive bags.
pale red bags contain 5 wavy blue bags, 5 dark purple bags, 1 bright tomato bag, 4 dark tan bags.
vibrant red bags contain 5 wavy gray bags, 5 dark tomato bags.
dim salmon bags contain 2 faded crimson bags.
shiny blue bags contain 4 muted tan bags, 2 vibrant orange bags.
vibrant white bags contain 3 mirrored cyan bags.
dark violet bags contain 5 vibrant blue bags, 3 wavy tomato bags.
pale gold bags contain no other bags.
dim silver bags contain 4 drab tan bags, 4 pale silver bags, 5 clear bronze bags, 4 drab maroon bags.
drab blue bags contain 5 vibrant indigo bags, 3 muted turquoise bags.
drab plum bags contain 2 dim turquoise bags, 2 drab violet bags, 1 light gray bag, 3 clear tan bags.
bright plum bags contain 3 wavy olive bags.
dark fuchsia bags contain 4 dotted indigo bags, 3 dark brown bags, 1 clear white bag.
bright turquoise bags contain 1 posh lime bag, 2 wavy olive bags, 1 pale crimson bag.
dotted turquoise bags contain 3 faded plum bags, 1 bright tomato bag.
shiny indigo bags contain 1 wavy chartreuse bag.
dark yellow bags contain 2 light gold bags.
posh olive bags contain 2 shiny indigo bags.
light chartreuse bags contain 5 drab turquoise bags, 2 faded purple bags, 3 faded gray bags.
vibrant tomato bags contain 3 light olive bags, 4 shiny purple bags.
posh brown bags contain 4 shiny green bags, 1 pale purple bag.
bright chartreuse bags contain 3 light gold bags.
dotted lime bags contain 5 wavy cyan bags.
drab violet bags contain 4 dark beige bags, 1 plaid gold bag, 3 faded beige bags.
drab green bags contain 4 dotted bronze bags, 5 clear silver bags, 4 faded salmon bags.
wavy beige bags contain 2 clear cyan bags, 2 dim tomato bags.
wavy yellow bags contain 4 pale green bags, 3 mirrored green bags, 5 faded brown bags, 1 clear orange bag.
plaid tomato bags contain 3 dull yellow bags, 2 faded blue bags, 1 dull teal bag.
dull red bags contain 4 posh green bags, 1 shiny salmon bag, 2 bright tomato bags, 4 vibrant red bags.
striped salmon bags contain 4 dim bronze bags, 4 light gold bags, 3 posh beige bags.
dim crimson bags contain 1 dull crimson bag, 4 drab silver bags.
plaid silver bags contain 3 dull black bags, 5 shiny silver bags, 4 dark beige bags, 2 clear aqua bags.
clear bronze bags contain 1 drab coral bag, 2 vibrant red bags.
dotted gray bags contain 1 plaid plum bag, 2 dotted purple bags, 5 striped violet bags, 3 bright tomato bags.
striped silver bags contain 2 plaid coral bags, 5 bright orange bags, 1 pale brown bag.
shiny beige bags contain 4 dim turquoise bags.
posh green bags contain no other bags.
plaid gold bags contain 3 pale fuchsia bags, 5 dull lime bags, 5 wavy chartreuse bags, 5 dim tomato bags.
dim teal bags contain 5 pale beige bags, 2 faded blue bags, 5 dotted tan bags, 5 vibrant tomato bags.
bright red bags contain 4 drab lavender bags, 1 dark purple bag, 2 wavy violet bags.
dotted teal bags contain 5 dull crimson bags.
faded gray bags contain 4 mirrored red bags.
pale purple bags contain 3 faded gray bags, 1 clear gold bag, 4 clear cyan bags.
striped crimson bags contain 4 dim aqua bags, 3 pale magenta bags, 1 drab white bag, 1 vibrant purple bag.
mirrored purple bags contain 3 muted gray bags.
muted maroon bags contain 3 plaid crimson bags, 4 posh aqua bags.
muted gold bags contain 3 pale fuchsia bags, 2 dotted teal bags, 3 dotted chartreuse bags, 4 vibrant lime bags.
wavy silver bags contain 2 plaid beige bags, 3 dull aqua bags, 2 pale lavender bags.
dim aqua bags contain 5 bright beige bags.
dark tan bags contain 4 pale gold bags.
light yellow bags contain 4 dotted gray bags, 5 pale teal bags.
bright blue bags contain 3 shiny coral bags, 4 striped salmon bags.
striped cyan bags contain 5 light turquoise bags.
light gray bags contain 4 vibrant teal bags, 1 shiny turquoise bag, 1 wavy olive bag, 5 dim white bags.
light cyan bags contain 3 dark gray bags, 5 clear lavender bags, 4 dark beige bags.
light blue bags contain 5 dim black bags, 4 drab tomato bags, 2 dim turquoise bags.
dull crimson bags contain 3 pale silver bags, 2 faded beige bags.
dotted beige bags contain 2 dotted aqua bags.
shiny olive bags contain 4 bright plum bags, 4 clear plum bags, 2 wavy green bags, 5 faded tomato bags.
striped turquoise bags contain 1 drab black bag.
pale chartreuse bags contain 5 dotted brown bags.
mirrored turquoise bags contain 4 shiny gold bags, 3 dark chartreuse bags.
posh beige bags contain 3 dotted tan bags.
drab gray bags contain 3 vibrant aqua bags.
shiny silver bags contain 4 plaid gold bags, 5 shiny green bags.
bright crimson bags contain 5 faded yellow bags, 4 bright plum bags, 4 mirrored gold bags.
dim yellow bags contain 2 plaid lime bags, 5 bright salmon bags, 4 mirrored bronze bags.
dark crimson bags contain 4 dull blue bags, 2 light olive bags, 4 mirrored green bags.
faded aqua bags contain 1 dotted chartreuse bag, 1 muted orange bag.
pale turquoise bags contain 4 dull silver bags.
clear orange bags contain 1 pale gray bag, 5 striped bronze bags, 5 dim aqua bags.
mirrored red bags contain 1 muted purple bag.
drab silver bags contain no other bags.
faded silver bags contain 5 mirrored turquoise bags, 4 striped purple bags.
wavy fuchsia bags contain 2 faded purple bags, 1 wavy cyan bag, 2 muted cyan bags.
clear black bags contain 4 drab turquoise bags, 1 plaid lime bag.
dim olive bags contain 5 bright chartreuse bags, 3 striped silver bags.
mirrored tan bags contain 2 striped indigo bags, 3 wavy gray bags, 3 clear tan bags.
mirrored yellow bags contain 2 plaid plum bags, 3 striped salmon bags, 4 dim maroon bags.
shiny salmon bags contain 5 dotted plum bags, 5 pale crimson bags.
dotted crimson bags contain 3 dull yellow bags.
shiny fuchsia bags contain 5 plaid lime bags.
drab turquoise bags contain 2 dull crimson bags.
mirrored cyan bags contain 3 posh green bags, 5 striped olive bags, 5 vibrant red bags.
faded crimson bags contain 3 muted silver bags, 4 shiny olive bags.
light magenta bags contain 3 posh crimson bags, 5 pale purple bags.
faded violet bags contain 3 vibrant lime bags, 1 dim magenta bag, 1 dull lime bag.
dotted black bags contain 2 light gold bags, 2 dim bronze bags, 4 wavy turquoise bags.
bright beige bags contain 4 vibrant orange bags, 4 dark chartreuse bags, 1 muted gray bag, 2 bright tomato bags.
striped green bags contain 3 pale beige bags, 1 pale brown bag, 2 posh brown bags, 5 striped olive bags.
dotted red bags contain 4 vibrant orange bags, 2 pale gold bags.
plaid fuchsia bags contain 5 pale teal bags, 5 pale fuchsia bags, 4 faded gray bags.
light beige bags contain 1 muted red bag, 5 dotted purple bags, 3 striped salmon bags.
dim chartreuse bags contain 5 muted maroon bags, 4 wavy maroon bags.
clear chartreuse bags contain 3 striped lavender bags, 2 clear blue bags.
pale silver bags contain 2 dark teal bags.
faded olive bags contain 4 dotted turquoise bags, 4 drab indigo bags, 5 drab violet bags, 3 shiny blue bags.
clear blue bags contain 1 muted black bag.
dull tan bags contain 5 clear crimson bags, 3 dim tomato bags.
dark cyan bags contain 4 wavy magenta bags, 5 vibrant olive bags, 2 posh gray bags, 5 dull magenta bags.
dotted white bags contain 1 bright magenta bag, 3 pale red bags.
muted teal bags contain 5 posh fuchsia bags, 4 drab turquoise bags, 4 posh red bags.
mirrored coral bags contain 1 faded purple bag, 2 bright magenta bags, 5 dark yellow bags, 3 light plum bags.
dull orange bags contain 4 dotted blue bags, 5 clear gray bags, 3 vibrant red bags.
bright aqua bags contain 4 muted lime bags, 2 wavy plum bags, 1 shiny olive bag.
light maroon bags contain 1 shiny gold bag, 4 light beige bags, 1 drab black bag.
dim green bags contain 4 dull brown bags.
striped black bags contain 4 dotted crimson bags.
mirrored bronze bags contain 4 mirrored chartreuse bags, 3 dull lime bags, 3 wavy turquoise bags.
striped aqua bags contain 4 dark gray bags, 5 faded beige bags, 2 dull lime bags.
shiny coral bags contain 5 mirrored white bags, 5 shiny blue bags.
striped orange bags contain 4 pale silver bags, 4 pale olive bags, 4 shiny olive bags, 2 bright chartreuse bags.
vibrant crimson bags contain 5 shiny olive bags, 5 striped violet bags, 2 posh beige bags.
dotted chartreuse bags contain 5 bright turquoise bags, 5 bright magenta bags.
vibrant purple bags contain 4 posh violet bags.
vibrant violet bags contain 5 posh aqua bags, 4 mirrored white bags, 4 dotted tan bags, 4 mirrored purple bags.
dotted violet bags contain 3 bright brown bags, 3 pale yellow bags, 4 light gray bags, 5 dark green bags.
muted black bags contain 2 light violet bags, 5 muted bronze bags.
mirrored orange bags contain 1 plaid magenta bag, 5 muted red bags, 3 pale lime bags.
faded magenta bags contain 3 striped cyan bags, 4 muted silver bags.
clear gray bags contain 4 muted gray bags, 2 wavy turquoise bags, 3 dotted plum bags.";

        public string handheldInstructionsTest = @"nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6";

        public string handheldInstructions = @"acc -7
acc +6
acc +4
nop +191
jmp +199
acc +44
acc -9
jmp +505
acc -12
acc +45
jmp +204
jmp +129
acc +17
nop +287
jmp +584
acc +16
jmp +363
acc +4
nop +142
acc +34
nop +345
jmp +522
jmp +53
acc -10
jmp +524
jmp +492
jmp +319
acc -9
jmp +550
acc -19
jmp +15
acc +24
jmp +30
acc -19
acc +12
acc -2
jmp +274
nop +91
acc +10
acc +4
jmp +501
acc +49
acc +29
jmp +488
jmp +504
jmp +277
acc +20
acc +34
jmp -40
acc +10
acc -4
acc -19
acc +38
jmp +239
acc -16
acc -3
nop +513
jmp +526
jmp +131
nop +539
acc -11
jmp +470
acc +30
jmp +166
acc +17
acc -16
nop +315
jmp +364
acc +15
nop -61
acc -12
nop +147
jmp -31
acc -9
jmp +324
acc +0
jmp +1
jmp +321
acc +0
acc +6
acc -17
acc +13
jmp +461
jmp +184
acc +22
jmp +182
jmp +504
nop +131
acc +12
acc -6
acc +29
jmp +187
acc +17
jmp +67
jmp -2
acc +50
acc +17
jmp +442
acc +8
nop +146
acc -12
acc +32
jmp +237
jmp +1
acc +34
acc +1
acc +18
jmp +274
acc +17
acc -12
jmp +282
acc +49
acc +11
acc +28
acc +40
jmp +79
acc +19
acc -8
nop +87
jmp +347
acc +48
nop +189
jmp +419
acc +31
jmp +1
acc +31
jmp +1
jmp -94
nop -45
nop +412
acc -14
acc +35
jmp -49
jmp +177
jmp +127
jmp +360
jmp +114
acc -11
nop +248
jmp -64
acc +31
acc +23
acc +4
nop +110
jmp +61
acc +45
nop +444
jmp +218
jmp -131
acc +36
jmp -142
nop +361
acc -3
acc +6
jmp +161
acc +24
acc -7
acc +4
acc +31
jmp +91
jmp -20
jmp +1
nop -11
jmp -146
acc +25
acc +33
jmp +52
acc -7
jmp +82
acc +7
acc +21
acc +6
jmp +397
acc +12
acc +5
acc -9
acc +24
jmp +371
acc +50
acc +47
acc +19
jmp +238
jmp +396
acc -16
nop +394
jmp +180
acc +1
acc +40
jmp +237
acc +22
nop -30
jmp -129
acc +22
jmp +232
acc +23
acc +27
acc +47
jmp +133
acc +0
nop +30
acc +11
acc -9
jmp +381
jmp +75
jmp -64
acc -15
acc +29
acc +49
jmp +195
nop +113
acc -16
nop +312
acc +6
jmp -44
acc +26
acc +40
jmp +272
jmp +83
jmp +365
acc +24
acc +4
jmp +29
acc +8
jmp -137
acc +13
jmp +1
acc +33
nop -182
jmp +22
jmp +9
nop +20
acc +14
nop +291
jmp -28
jmp -83
acc +18
acc +5
jmp +32
acc +48
nop -128
acc +28
jmp +225
acc +29
nop +280
jmp +304
acc +37
acc +50
acc +30
jmp +131
jmp -60
acc +27
jmp +272
jmp +358
acc -1
acc +37
jmp +203
acc +1
acc +37
acc +12
acc -16
jmp +263
acc -16
acc +30
jmp +86
acc +26
acc +6
jmp +344
jmp -147
jmp -185
acc -5
acc -3
acc +7
acc +9
jmp -205
nop -85
acc -4
acc -1
jmp +266
acc +19
nop -143
acc -3
jmp -12
acc +12
acc -18
jmp +326
acc +39
jmp +165
nop -279
acc +19
acc +46
acc +5
jmp -163
acc -13
jmp +1
acc +33
acc +44
jmp -62
acc -10
acc +7
jmp +240
acc -19
jmp -190
acc -12
jmp -167
acc -2
nop -288
acc -13
jmp +303
acc +24
jmp -283
jmp +309
nop +190
acc +38
acc -12
jmp -47
acc +15
acc +31
jmp -259
nop +154
acc +25
acc +8
jmp -295
acc +37
acc +34
acc -18
acc +41
jmp +156
acc +17
acc +37
jmp -243
nop -318
acc +45
acc +33
jmp +139
acc -6
acc +34
acc +25
acc +3
jmp +260
jmp +1
acc +24
jmp +154
acc +34
acc -19
jmp +211
acc +28
jmp +98
acc +45
jmp -143
acc +41
acc +8
acc +33
nop +217
jmp +119
acc +21
jmp -150
acc +25
acc +19
jmp +1
acc +20
jmp +209
acc +43
acc +18
acc +2
jmp -159
acc +25
acc +20
acc -4
acc +45
jmp +89
nop +33
acc +27
jmp +190
acc +47
acc +36
jmp +180
acc +3
jmp +1
jmp -349
jmp -6
jmp -244
acc +2
acc +42
jmp -357
acc +3
jmp -377
acc +31
nop -292
acc +6
acc +9
jmp -212
jmp -91
acc +11
jmp +119
acc -18
acc +38
acc +31
jmp -261
jmp +1
acc +2
jmp -197
acc +0
jmp +1
acc +40
acc +31
acc +4
acc +45
jmp -68
acc -17
acc +8
nop -384
jmp -193
acc +22
nop +170
acc -19
acc +34
jmp -321
acc +46
jmp +130
acc -19
jmp +115
acc -12
acc +23
acc +16
jmp -94
acc +11
nop -286
jmp -276
acc +36
acc +25
jmp -32
acc +6
acc +39
jmp +171
acc -5
nop -131
jmp -368
acc +41
acc -7
nop -336
jmp -428
acc +21
acc +45
jmp -225
acc -2
acc +14
acc +29
jmp -439
acc +36
acc +26
jmp -433
acc +29
acc +36
acc +31
jmp -232
nop -210
nop -44
jmp -382
nop -119
acc +43
jmp +1
jmp -24
acc -13
acc +22
acc +16
jmp +90
nop -443
acc +23
acc +15
acc -3
jmp -225
jmp -448
acc +21
acc -19
acc +23
jmp +1
jmp -447
acc +36
acc -1
acc +31
nop +8
jmp +97
jmp -96
acc -16
acc +7
acc -2
jmp +1
jmp -237
jmp +1
acc -12
acc +29
acc -1
jmp -188
acc +8
jmp -453
nop -234
acc +46
acc +20
acc +24
jmp -68
jmp -178
acc +42
jmp -469
acc +19
acc +35
jmp -4
acc +49
jmp +65
nop +15
nop -209
acc +27
jmp -261
acc +15
jmp -344
acc +13
acc +43
jmp -194
jmp +1
jmp -335
nop -424
acc -13
nop -387
jmp -333
acc +33
acc +30
jmp -272
acc +16
acc +5
acc +21
acc +41
jmp -312
acc +50
jmp -429
nop +57
jmp -212
acc +7
acc -13
jmp -252
jmp -277
jmp -114
jmp -528
jmp -40
jmp -275
acc +27
nop -322
jmp -356
acc -11
jmp -96
nop -9
acc -15
jmp -194
acc +9
acc +47
acc +44
jmp -459
acc -2
acc -12
nop -354
jmp -166
acc +44
acc +23
jmp -503
acc +47
acc +39
acc +10
acc +14
jmp -543
acc +43
jmp -25
jmp -52
acc -19
jmp -423
acc +35
acc +22
acc +10
acc +16
jmp -527
jmp -482
acc +2
acc +21
acc -17
jmp -417
jmp -282
acc +16
nop -424
nop -527
jmp -207
acc +23
acc +21
jmp -503
acc +17
acc -14
jmp -189
acc +43
acc +14
acc +11
nop -427
jmp -54
acc +8
nop -37
nop -542
jmp -332
acc +27
jmp +7
jmp -98
acc +50
acc +0
acc +48
acc +0
jmp -517
acc +15
acc +10
jmp -478
jmp -141
acc +0
acc +18
jmp -468
acc +49
jmp -112
nop -536
acc -14
acc -13
acc +34
jmp +1";

        public string encodingsTest = @"35
20
15
25
47
40
62
55
65
95
102
117
150
182
127
219
299
277
309
576";

        public string encodings = @"26
36
37
9
8
22
41
5
17
44
40
31
10
33
30
50
24
4
12
46
39
45
42
7
27
13
58
11
14
53
9
15
23
18
16
21
17
49
19
20
32
31
22
30
24
35
28
33
25
47
57
26
27
29
83
34
37
36
59
46
39
51
44
54
56
48
49
100
62
50
52
72
53
55
60
96
61
91
65
70
85
87
88
114
83
113
92
93
97
104
142
99
102
103
153
105
108
115
116
148
144
152
177
135
167
171
201
256
182
176
252
185
190
196
203
202
348
240
208
292
213
300
323
301
315
367
302
502
393
357
353
358
390
760
361
375
492
710
398
405
448
509
421
594
505
566
810
690
603
924
655
1317
711
823
714
1171
719
736
759
1080
773
803
819
953
1528
869
1195
1522
1071
1509
1169
2270
1314
1514
1369
1366
1425
1430
2620
2125
1455
1830
1495
1532
4045
1576
1622
2397
1822
2501
3331
2240
2385
2664
2942
2483
2680
2683
6285
2791
2796
2855
2987
4522
2950
3108
3198
3317
4207
3398
3816
5031
4809
4062
4868
4625
5667
5049
5338
5163
5587
5363
7318
6506
5646
5651
7405
5937
7214
9874
6306
10612
7379
11586
9708
9179
15648
8871
8687
16263
9674
10212
10387
15046
15901
19548
11009
31549
40236
11297
18965
13151
17087
19920
16014
22320
17766
16558
17558
30262
17866
18361
19083
19984
19886
33617
39878
21396
26343
22306
24448
24160
27311
27855
63879
29165
35097
32572
47775
33572
34324
40072
57630
35919
53325
36227
37444
38969
44046
41282
45844
43702
45556
58020
46466
48608
51471
55166
94135
80653
70016
66144
70243
80251
83910
76413
72146
73363
77509
88915
73671
103576
99302
84984
188560
89258
181085
92022
95074
97937
136160
158162
128529
136387
143379
138290
168180
142389
157273
145509
149776
147034
169531
158655
162586
162929
191324
281669
174242
258003
187195
187096
189959
193011
226466
264689
264916
266819
274677
389395
301044
287898
320202
292543
308095
342787
309620
480909
321584
325515
438931
374291
361338
361437
532680
377055
419477
382970
607476
491155
684166
531735
541496
635135
602163
1216846
580441
600638
744992
617715
631204
1022890
647099
686952
686853
722775
735629
738393
738492
1271073
1903798
1067136
874125
1032651
1149450
1073231
1353344
1121937
1181079
1613092
1231842
1198156
1750088
1248919
1264814
1278303
1333952
2436941
2590651
1805529
1458404
2222681
2936449
1941261
1906776
1947356
2105882
2980007
2872025
2195168
2455889
2320093
2303016
2379235
2429998
2447075
2707323
2513733
2736707
2543117
3263933
5086558
3365180
4136429
3399665
3405760
4053238
4863210
3848037
3854132
4485117
4758905
4498184
4515261
4574403
4816749
4623109
4682251
4826310
5807050
4960808
5056850
5250440
8422030
5908297
6629113
6764845
7219312
9361394
7897849
7253797
8422440
8717342
9932691
8339249
9138370
12962358
10489301
13383248
9631253
9439858
9305360
16126239
9787118
10017658
10211248
16392167
14611834
13393958
17152003
15104094
16615191
14473109
15151646
15593046
19950349
17056591
18936613
25032904
17477619
18443730
19071111
27108872
19226976
18745218
31230333
19516608
19804776
36342516
20228906
23605206
27867067
31668425
31837688
36844097
35101995
43969517
29624755
36704595
32649637
35500321
34534210
36414232
35921349
38298087
37188948
68010941
38974124
62714735
38261826
39321384
39745514
64726750
43834112
48095973
60309801
130725676
61293180
67183847
66329350
62274392
87841487
110163462
99283925
72689269
70034531
70455559
75388356
73110297
75450774
76163072
77235950
149484846
77583210
78007340
79066898
132308923
127001142
114425323
131748739
133982449
123567572
134403477
128603742
132729951
137662748
140490090
104054607
145799566
148038769
232658349
143565856
148498653
200111439
179505381
153399022
154819160
155590550
202634470
157074238
213470375
218479930
248407772
238458084
310409710
272066225
227622179
252093376
289365422
286161401
258873767
396446541
247620463
439560423
291604625
430256649
406912536
382441339
308218182
395532322
402439623
311893398
466080263
359708708
370544613
446102109
648736579
479715555
499688404
475242642
530939992
575526823
545035168
506494230
577766026
539225088
986209785
555838645
599822807
603498023
620111580
671602106
667926890
990656193
861612585
730253321
682438011
805810817
834951350
925817664
921344751
954958197
1133604671
1006182634
1014467730
1062332875
1432311894
1045719318
1868143692
1223609603
1095063733
1609680657
1155661452
1203320830
1271424913
1545929244
1339528996
1488248828
1608255675
1731628481
1565204671
1744770886
1939415488
1756296101
1932000298
2179323989
2000677515
3476399367
2571387305
2250725185
2108052193
2317144231
2904733667
2298384563
4230384861
3695711589
4503387603
6248158489
2474745743
3003053394
2827777824
2947784671
3935620090
5936297605
3296833152
4040052491
3501066987
3688296399
5155458852
4406436756
5007101813
4549109748
4358777378
5078503009
4425196424
4582797936
4615528794
6163042142
6234004653
5302523567
5422530414
5477799137
5975812730
5771578895
5830831218
6124610976
11398343144
17522954120
6797900139
6985129551
8990819966
9971640162
8113492823
8765214134
8783973802
8907887126
8941575314
10591341524
9040725218
9007994360
10558610666
9918052361
10725053981
14889825110
14838825578
10900329551
16956769713
11602410113
13783029690
11955442194
20739415996
16769540301
15750343685
14911392962
15769103353
16878706957
16897466625
17805939352
17549187936
23897819470
18048719578
17949569674
18926046721
18958777579
19566605026
20476663027
25811722513
38736645048
22502739664
22855771745
27797796176
23557852307
25385439803
26866835156
27705785879
55615352005
42422376771
30661736647
30680496315
32647810310
33776173582
34847036299
35755509026
43360910449
45825612735
45747365850
63775182409
38492651747
38525382605
42069344690
64925116435
45358511409
46060591971
46413624052
80205547708
48943292110
64456669897
52252274959
54572621035
66198437626
61342232962
63309546957
63328306625
65527532614
81853562196
68623209881
104020184361
129148839818
80561996437
77018034352
84272748455
80594727295
83851163156
110870293949
131951516506
91419103380
91772135461
95003884081
131590655387
143871543394
103515913145
119029290932
106824895994
145991724415
124651779919
126869765576
126637853582
172139123026
134150742495
145641244233
149185206318
157580030789
157612761647
164445890451
168123911611
164867475750
172013830675
291083744033
256010102312
183191238841
186422987461
186776019542
295176930733
210340809139
222545204077
225854186926
231476675913
233462749576
251289633501
291505329332
275823059900
291730773284
325736673258
303221275022
344356050331
523207449197
329626592322
322058652098
329313366201
332991387361
336881306425
355205069516
774497082698
1000351269624
617242002590
373199007003
397116828681
448399391003
432886013216
454021879990
457330862839
509285809476
484752383077
613789425382
567328389232
567553833184
594952048306
625279927120
632534641223
1096555734796
1373550276627
994038192553
776080532088
662304753562
669872693786
1454373149614
770315835684
1110704144565
806085020219
821598398006
827220886993
830002841897
1199863030455
942083245916
911352742829
966616672315
1052080772309
1454133039229
1276094178944
1134882222416
1389152231190
1804754916202
1619318119673
1763681643922
2203553118524
1440188529470
1492307595459
1332177447348
1483903151568
2300504974019
2141946276371
2946440634688
2216373118183
1627683418225
2449320961570
2251943802764
1741355584726
1853435988745
1877969415144
2046234965245
2018697444624
3193907147392
2410976401360
2772365976818
2524034453606
2721329678538
2816080598916
4834778043540
3119991013684
2824485042807
2924091681038
2959860865573
3185613436093
3625849427939
3594791573471
4235070562807
4574124052913
4495555926815
3369039002951
3731405403889
3993299387490
3760053029350
4264412390105
6906532328175
4064932409869
4429673845984
4935010854966
6149883881545
5245364132144
5340115052522
5645421359576
6010098478900
5748576723845
5784345908380
5883952546611
7681169362908
6145474301666
11402088254990
6963830576422
7354844602821
7362338390441
8329344799974
7100444406840
7129092032301
7491458433239
7753352416840
7824985439219
10890785491720
13429746086753
8494606255853
10683587578811
10180374987110
10585479184666
11393998083421
11088691776367
11429767267956
18558859300257
11532922632225
13826643664574
12984396953451
13245918708506
15595050662693
14064274983262
14491430422742
21575263508480
14853796823680
35401907173054
53960766473311
33005030776436
15244810850079
15578337856059
18674981242963
19080085440519
54580294284916
19178193834664
20765854171776
21674170961033
26333502626446
22926920715646
22518459044323
27008105124015
28318074087316
27737349131248
32501624907537
26230315661957
37009889467065
28555705406004
28918071806942
70158632140975
45413588066965
30098607673759
30823148706138
62600232581296
41475126512036
33919792093042
34253319099022
61261424223037
38258279275183
57180239814668
39944048006440
44192630005356
44601091676679
45445379759969
52617066718082
48748774706280
64351926772781
53967664793205
56655420938190
73519163483621
109765514839746
57473777212946
85667756517392
59016679480701
60921756379897
97274958755884
126952159354077
64742940799180
72511598374205
92561114724522
68173111192064";
    }
}
