pipeline {
    agent any
    parameters {
        string(name: 'GIT_HTTPS_PATH', defaultValue: 'https://github.com/tavisca-vshah/WebApiTests.git')
        string(name: 'TEST_FILE_PATH', defaultValue: 'WebApi.Tests/WebApi.Tests.csproj')
        string(name: 'SOLUTION_FILE_PATH', defaultValue: 'WebApi/WebApi.sln')
        string(name: 'SOLUTION_NAME', defaultValue: 'WebApi')
        string(name: 'DOCKER_USERNAME', defaultValue: 'vshahks4578')
        string(name: 'DOCKER_PASSWORD',defaultValue:'@V49K52A4D@')
        string(name: 'DOCKER_REPO_NAME',defaultValue:'vshahks4578/webapi')
        string(name: 'IMAGE_VERSION', defaultValue:'latest')
  }

    stages {
        stage('Build') {
            steps {
                bat '''
              
                echo "----------------------------Build Project Started-----------------------------"
                dotnet build %SOLUTION_FILE_PATH% -p:Configuration=release -v:n
                echo "----------------------------Build Project Completed-----------------------------"
               
                echo "----------------------------Test Project Started-----------------------------"
                dotnet test %TEST_FILE_PATH%
                echo "----------------------------Test Project Completed-----------------------------"
               
                echo "----------------------------Publishing Project Started-----------------------------"
                dotnet publish %SOLUTION_FILE_PATH% -c Release -o ../publish
                echo "----------------------------Publishing Project Completed-----------------------------"
               
                echo "----------------------------Docker Image Started-----------------------------"
                docker build -t %DOCKER_REPO_NAME%:%IMAGE_VERSION% --build-arg project_name=%SOLUTION_NAME%.dll .
                echo "----------------------------Docker Image Completed-----------------------------"
                '''
            }
            }
               
        stage('Deploy') {
            steps {
                bat '''
                echo "----------------------------Deploying Project Started-----------------------------"
                docker login -u %DOCKER_USERNAME% -p %DOCKER_PASSWORD%
                docker push %DOCKER_REPO_NAME%:%IMAGE_VERSION%
                echo "----------------------------Deploying Project Completed-----------------------------"
                '''
            }
        }
    }
}