# docker-kubernetes-demo

## How do build the image?

```
docker build . -f Hello-dotnet-core/Dockerfile -t softwarehuset/my-application:my-version
```

## How do i push the image?

```
docker push softwarehuset/my-application: my-version
```

## I need to retag an image

```
docker tag softwarehuset/my-application:my-version some-externalservice/softwarehuset/my-application
```



# Getting  Kubernetes 

## What if i am using a windows machine

There is several distributions that makes it easy to run kubernetes on your own windows machine.

 - [minikube](https://minikube.sigs.k8s.io/docs/start/)
 - [Openshift v4](https://developer.ibm.com/blogs/install-openshift-4-on-your-laptop/)
 - [RandersDesktop](https://rancherdesktop.io/)

## On Linux Server

Start out by trying k3s - https://k3s.io/

```
curl -sfL https://get.k3s.io | sh -
```

### Get Kube Config file from k3s
run the following command on your virtual machine or hosted server

```
cat /etc/rancher/k3s/k3s.yaml
```

Replace ```https://127.0.0.1:6443``` with the server ip and save your kube config file locally at ~/mycluster.yml. now set your kube config temporary like this ```export KUBECONFIG=~/mycluster.yml```

You can now run ```kubectl get node``` to verify connectivity

```
➜  Hello-dotnet-core git:(main) ✗ kubectl get node
NAME                STATUS   ROLES                  AGE   VERSION
ubuntu-4gb-hel1-2   Ready    control-plane,master   23m   v1.21.5+k3s2 
```