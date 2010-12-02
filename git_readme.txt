（说明，//后的文字表示注释）

1、创建你本机的git key

1)程序->git->git bash

2)在终端窗口运行：
$ cd ~/.ssh     
$ rm id_rsa*
$ ssh-keygen -t rsa -C "your@email.com"     //注意：这里的your@email.com填写你的真实email地址,后面全部回车，直到显示"The key fingerprint is:
                                          //e8:ae:60:8f:38:c2:98:1d:6d:84:60:8c:9e:dd:47:81 your@email.com",表示你的key已经生成。

3）找到id_rsa.pub文件，Q给我
$ ls                           //你会发现id_rsa.pub文件，用windows资源管理器即可，缺省在C:盘下

2、设置你的git全局环境（比如魏建楠）
$ git config --global user.name "Weijn"
$ git config --global user.email "Weijn@gmail.com"       //这是为了识别大家各自的提交代码
//为你的git设置远程的源码库地址
$ git remote add origin git@github.com:freeopen/MarkTest.git

3、注册一个帐号（免费），把帐号告诉我，我将添加你的帐号到共同的源码库中。
注册地址为：github.com

4、一切准备就绪后，你可以重新装硬盘上找个干净地方，然后进入 git bash ，输入如下命令，从服务器上克隆源码到你的本地硬盘，它将自动为大家建立统一的git版本环境。
$ git clone git@github.com:freeopen/MarkTest.git

5、ok，这时候，我们的统一版本环境已经建立好了，这时候开始学习如何协同工作了。

6、（永远记住，协同开发时，你永远工作在你自己的分支上）首先建立分支，比如魏建楠，打开git bash(这玩意只有用命令行描述起来清楚，坚持命令行吧先)
$ git branch wjn     //创建魏的个人分支
$ git checkout wjn   //切换到魏的分支
$ git branch         //检查一下，发现wjn前面有星号，说明切换成功，说明当前你工作在魏的分支

7、建了分支以后，必须还要设置一下远程的源码库地址
$ git remote add wjn git@github.com:freeopen/MarkTest.git  //注意：这里add 的 wjn

8、每日工作习惯
1）首先检查自己是否在自己的分支上
$ git branch

2）其次检查远程库有没有更新
$ git fetch    

3)然后，小魏同学哼哧哼哧写自己的新代码

9、代码写完了后，开始提交
1）首先当然是提交到本地的git库中，进入git bash后
$ git add .     //提交所有程序进git库 （你也可以直接用可视化的TortoiseGit提交）
$ git commit -m "小楠加了什么新功能呢？"  //commit 才是真正提交，前面的add只是建立索引，记住，备注信息要写清楚。（你的本地提交不会影响任何人，因为你在你的分支）
$ git push origin wjn   //把你的分支代码推上远程服务器


10、提交了分支还没完，谁管你的分支，其他人关心的是你的代码对主库(master)的影响。所以你要合并你的代码到主库（注意，为了国际共产主义，请做好代码检查，别合并代码后，把别人写的好东西变成坏东西了）
$ git checkout master   //切换到主库
$ git merge wjn         //合并小楠的代码,合并建议用TortoiseGit,简单些，主要是处理冲突，如果没有代码冲突，合并很简单
$ git push              //推送到远程服务器的主库


11、糟糕，柯娃子的代码又改了些，怎么办





