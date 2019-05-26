<template>
  <section class="pure-g main">
    <div class="pure-u-1-1">
      <h2 class="title">已上线</h2>
    </div>

    <project-item v-for="project in onlineProjects" :project="project" :key="project.name"/>

    <div class="pure-u-1-1">
      <h2 class="title">筹备中</h2>
    </div>

    <project-item v-for="project in comingSoonProjects" :project="project" :key="project.name"/>
  </section>
</template>

<script>
const projectStatus = {
  online: 'online',
  comingSoon: 'coming-soon'
}

import ProjectItem from './project-item.vue'

export default {
  data() {
    return {
      projects: [
        {
          name: 'UA Viewer',
          description: '通过 navigator 查看浏览器的 User Agent',
          router: '/ua',
          status: projectStatus.online
        },
        {
          name: 'GUID Gen',
          description: 'GUID 生成器',
          router: '/guidgen',
          status: projectStatus.online
        },
        {
          name: 'Coming Soon',
          description: '敬请期待',
          router: '',
          status: projectStatus.comingSoon
        }
      ]
    }
  },
  computed: {
    onlineProjects() {
      return this.projects.filter(p => p.status === projectStatus.online)
    },
    comingSoonProjects() {
      return this.projects.filter(p => p.status === projectStatus.comingSoon)
    }
  },
  components: {
    ProjectItem
  }
}
</script>

<style lang="stylus" scoped>
section.main .title
  margin: 0 16px
</style>
